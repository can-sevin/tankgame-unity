
using UnityEngine;
using UnityEngine.AI;
public class Perspective :Sense {
   
    float fieldOfView=55f;// Görüş alanı
    public Transform rayOrigin; 
    float viewDistance=150f; // Görüş mesafesi
    Transform playerTank;
    Vector3 dir;
    GameObject a;
    Animator fsm;
   
    public override void Initialize()
    {
       detectionRate = 0f;
       playerTank = GameObject.FindGameObjectWithTag("Friend").transform;
        
    }

    public override void UpdateSense()
    {
        fsm = GetComponent<Animator>();
        dir = (playerTank.position - transform.position).normalized; // iki tank arası yön vektörü
        if (Vector3.Angle(dir, transform.forward) < fieldOfView)
        {
           RaycastHit hitInfo;
           if(Physics.Raycast(rayOrigin.position,dir,out hitInfo , viewDistance)) // Görüş alanımda bir nesne varsa
            {
                Aspect aspect = hitInfo.collider.GetComponent<Aspect>();
                if (aspect != null)
                {
                    if(aspect.tankaspect== tAspect)
                    {
                       
                        Debug.Log("Enemy detected !!"); // Düşman algılandı mesajı ver
                        fsm.SetBool("isVisible", true);
                    }
                }
                else
                {
                    fsm.SetBool("isVisible", false);
                }
            }
        } 

    }
}
