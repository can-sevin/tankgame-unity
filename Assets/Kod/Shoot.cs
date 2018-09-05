using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform shellSpawn;
    public GameObject shellPrefab;
    float moveSpeed = 1500f; // Çok hızlı bir mermi

    void Start()
    {

    }
    private void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.Mouse0))       //sol tıka bastıkça
            Shooting();
    }
    
    float nextShoot = 0f;
    float frequency = 10f;
    public void Shooting()
    {
        if (Time.time > nextShoot)//unityde geçen süre
        {
            GameObject shell = Instantiate(shellPrefab, shellSpawn.position, Quaternion.identity);
            shell.GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * Time.deltaTime;
            nextShoot = Time.time + 1f/frequency;   //  her 0.1 saniyede ateş
            Destroy(shell, 2); //3 saniye sonra mermiyi yok et

        }
    }
   
}
