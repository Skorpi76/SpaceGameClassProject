using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion_Asteroid;
    public GameObject explosion_Player;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        if (other.tag == "Player")
        {
            Instantiate(explosion_Player, other.transform.position, transform.rotation);
            
           
        }

        Instantiate(explosion_Asteroid, this.transform.position, this.transform.rotation);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        
        
      
    }
}
