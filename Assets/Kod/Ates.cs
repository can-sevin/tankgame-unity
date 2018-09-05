using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour {

	// Use this for initialization
	
    private void OnTriggerEnter(Collider other) //ontriggerenter çünkü mermi ile birşeyierin teması olabilir
    {
        if (other.gameObject.tag == "Friend" || other.gameObject.tag == "Enemy") //düşman yada player ise çarptığım nesne
        {
            other.gameObject.GetComponent<Health>().TakeDamage(3f); //burada hasar alıyor
        }
    }
}
