using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNewWayPoint : StateMachineBehaviour {

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

        animator.GetComponent<TankAI>().FindNewWayPoint();
	}

}
