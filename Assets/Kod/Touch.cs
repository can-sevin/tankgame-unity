using UnityEngine;

public class Touch : Sense
{
    Aspect aspect;
    public override void Initialize()
    {

    }

    public override void UpdateSense()
    {
        if (aspect!= null)       // bir aspect varsa ve bu tankaspecte eşitse
        {
            if(aspect.tankaspect== tAspect)
            {
                Debug.Log("Touch detected !!"); // dokunma algılandı yazsın
              
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        aspect = other.GetComponent<Aspect>(); // Aspect kodunu alıyoruz
    }
    private void onTriggerExit(Collider other)
    {
        aspect = null;
    }
}
 
