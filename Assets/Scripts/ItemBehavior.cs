using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt_Pickup : MonoBehaviour
{
    public GameBehavior gamemanager;

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log(" Item collected!");

            gamemanager.Items += 1;
        }
    }
    
    void Start()
    {
       gamemanager = GameObject.Find("GameManager").GetComponent<GameBehavior>(); 
    }

   
    void Update()
    {
        
    }
}
