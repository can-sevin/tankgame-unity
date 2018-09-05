using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Shoot : MonoBehaviour {
    public Transform shellSpawn;
    public GameObject shellPrefab;
    float moveSpeed = 1500f; //çok hızlı bir değer
    float rotSpeed = 5f;
    public Transform player;
    void Start () {
		
	}
    void Update () { }

    float nextShoot = 0f;
    float frequency = 10f;
    public void Ates()
    {
        Vector3 dir = (player.position - transform.position);//yön vektörü oluşturduk.
        dir = dir.normalized;
        Quaternion rotation = new Quaternion();


        rotation.SetLookRotation(dir);//dönme yapar
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotSpeed * Time.deltaTime * 0.5f);

        if (Time.time > nextShoot)// unityde geçen süre
        {
            GameObject shell = Instantiate(shellPrefab, shellSpawn.position, Quaternion.identity);//etkisiz birim rotasyon
            shell.GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * Time.deltaTime;
            nextShoot = Time.time + 1f / frequency;//her 0.1 saniyede ateş
            Destroy(shell, 3f);
        }

    }
}
