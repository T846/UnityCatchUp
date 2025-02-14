﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce(0, 0, -5);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-5, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(5, 0, 0);
        }

        if (transform.position.y < -5){
            transform.position = new Vector3(0, 1, -2);
        }
    }

    void OnCollisionStay(Collision hit){
        if(hit.gameObject.tag == "Enemy"){
            transform.position = new Vector3(0, 1, -2);
        }
    }
}
