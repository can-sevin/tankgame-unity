using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesDurumu : StateMachineBehaviour {

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.gameObject.GetComponent<AI_Shoot>().Ates();
	}

}
