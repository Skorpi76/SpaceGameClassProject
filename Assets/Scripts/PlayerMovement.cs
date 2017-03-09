using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //Public fields 
    public float speed;

    // Privat fields
    private Rigidbody2D rb;

    //Initialize our vars
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
