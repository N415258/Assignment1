using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    
    //Decides how fast the bullet shoots
    public float bulletForce = 20f;

    void Update()
    //If the input key is activated then returns the following
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(FirePoint.forward * bulletForce, ForceMode.Impulse);
	}
        private void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.tag =="enemy")
        {
            Destroy(gameObject);
            
        }    
    }
    

}
