using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TankPlayer : MonoBehaviour {
    
    float movementValue, turnValue;
    float moveSpeed, rotspeed;
    void Start()
    {
        moveSpeed = 40f;
        rotspeed = 15f;  
       
    }
    void Update()
    {
        movementValue = Input.GetAxis("Vertical");
        turnValue = Input.GetAxis("Horizontal");

        transform.position += transform.forward * movementValue * moveSpeed * Time.deltaTime;
        Vector3 rotVector = new Vector3(0, 1, 0) * turnValue * rotspeed;
        transform.Rotate(rotVector);
    }
}
