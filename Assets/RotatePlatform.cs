using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        //rb.angularVelocity = -100f; // Set the angular velocity to rotate the platform counter-clockwise
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // If the player collides with the platform, stop its rotation
            rb.angularVelocity = -100f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
