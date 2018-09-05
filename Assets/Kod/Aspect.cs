using UnityEngine;
 public enum TankAspect //tankın görüşü
{
    ENEMY,//ise diğeri düşman
    FRIEND//ise digeri dost
}
public class Aspect : MonoBehaviour {
    public TankAspect tankaspect;
	
}
