using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text için tanımladık.

public class Health : MonoBehaviour {

    public Text text_Saglik;
    float saglik = 100f;
    // Use this for initialization
    void Start()
    {
        text_Saglik.text = saglik.ToString(); //oyun başlayınca sağlığı ekrana yaz

    }
    public void TakeDamage(float deger)
    {
        saglik = saglik - deger;


        if (saglik <= 0) //sağlığı 0 dan küçük eşitse öl
        {
            saglik = 0;
            Die();
        }

        text_Saglik.text = saglik.ToString(); //sağlığı güncelle
    }

    private void Die()

    {
        Destroy(gameObject);  //ölünce yok et
    }
}
