using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sense : MonoBehaviour, ISenseFaceee
{
    protected float elapsedTime; //Geçen zaman
    protected float detectionRate; //kontrol yapılması
    protected TankAspect tAspect = TankAspect.ENEMY;
  
    public abstract void Initialize();

    public abstract void UpdateSense();
    void Start()
    {
        Initialize();
    }
    void Update()
    {
        elapsedTime = Time.time;
        if (elapsedTime > detectionRate) //Eğer geçen süre değerivkontrol edilecek değerden büyükse 
        {
            UpdateSense();
            detectionRate = elapsedTime + 0.2f;  //saniyede 5 kere günceller
        }

    } 
}
