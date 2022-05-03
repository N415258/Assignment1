using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamecantroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameover;
    public void Gameover()
    {
        gameover.SetActive(true);
    }
    public void Reset()
    {   
        SceneManager.LoadScene("game1");
        
    }
}
