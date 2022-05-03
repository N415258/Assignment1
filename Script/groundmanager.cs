using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmanager : MonoBehaviour
{
    public GameObject[] groundprefab;
    public float spawn=0;
    public float groundlength=30;
    public int numberoftile=5;
    public Transform playertransform;
    private List<GameObject> activetiels = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<numberoftile;i++)
        {
            if(i==0)
            {
                spawnfile(0);
            }
            else
            {
            spawnfile(Random.Range(0,groundprefab.Length));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
      if(playertransform.position.z -35>spawn-(numberoftile*groundlength))
      {
        spawnfile(Random.Range(2,groundprefab.Length));
        Deletetile();
      }  
    }
    public void spawnfile(int tieldindex)
    {

        GameObject go =Instantiate(groundprefab[tieldindex],transform.forward*spawn,transform.rotation);
        activetiels.Add(go);
        spawn += groundlength;
    }
    public void Deletetile()
    {
        Destroy(activetiels[0]);
        activetiels.RemoveAt(0);
    }
}
