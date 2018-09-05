using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GezintiDurumu : StateMachineBehaviour {

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.gameObject.GetComponent<TankAI>().Patrol();
	}
}
