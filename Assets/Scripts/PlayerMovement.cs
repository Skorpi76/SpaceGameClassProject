using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //Public fields 
    public float speed;
    public GameObject laser;
    public Transform laserSpawn;

    // Privat fields
    private Rigidbody2D rb;
    private float nextFire = 0.3f; // how often the player can shoot
    private float myTime = 0.0f; // Var to hold our time 
    //Initialize our vars
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        myTime += Time.deltaTime; 
        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            Instantiate(laser, laserSpawn.position, laserSpawn.rotation);
            myTime = 0.0f;
        }
    }
    // when using physics use FixedUpdate, velocity = speed + direction    || Vecto2 = (x,y) 
    void FixedUpdate () {
      float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");


      Vector2 movement = new Vector2(moveHorizontal, moveVertical);
      rb.velocity = movement * speed;
      rb.position = new Vector2(Mathf.Clamp(rb.position.x, -8f, 4f), Mathf.Clamp(rb.position.y, -4f,4f));
    }
}
