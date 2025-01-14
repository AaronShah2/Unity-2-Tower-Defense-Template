﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringState : StateMachineBehaviour
{
    TowerManager tm;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       tm = animator.GetComponent<TowerManager>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if(tm.currentTarget != null) {
           animator.transform.rotation = tm.GetTargetDir();

           // checking if the enemy is within our range
           if(tm.GetTargetDis()<= tm.self.attackRange){
               tm.AttackTarget();
           }
       }
       else
       {
           // goes back back idling state if there is no target
           animator.SetBool("hasTarget", false);
       }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
