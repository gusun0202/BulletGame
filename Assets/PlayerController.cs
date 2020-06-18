using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbidy;
    public float speed = 8f;
    void Start()
    {
        playerRigidbidy = GetComponent< Rigidbody>();
    }

    
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbidy.velocity = newVelocity;
    }
    public void Die() {
        gameObject.SetActive(false); 

    }

}
