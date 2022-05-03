using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject gameover;

     private void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.tag =="tagbullet")
        {
            Destroy(gameObject);
        }    
    }
}
