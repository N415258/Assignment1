using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class palyercantroller : MonoBehaviour
{   
    public float movespeed=5f;
    public float speed=10f;
    public gamecantroller gameController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position=transform.position+new Vector3(0,0,movespeed*Time.deltaTime);
       
            
            if(Input.GetKey(KeyCode.RightArrow))
            {
                transform.position=transform.position+ new Vector3(speed*Time.deltaTime,0,0);
            }
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position=transform.position+ new Vector3(-speed*Time.deltaTime,0,0);
            }

            
    }
    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.tag =="enemy")
        {
            Destroy(gameObject);
            gameController.Gameover();
            
        }    
    }

}
