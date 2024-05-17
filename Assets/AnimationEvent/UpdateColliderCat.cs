using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateColliderCat : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ColliderManager colliderManager = GameObject.FindWithTag("Cat").GetComponent<ColliderManager>();
        
        Debug.Log($"{animator.GetCurrentAnimatorClipInfo(0)[0].clip.name}");

        if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "1")
        {
            colliderManager.SetCollider1();
        }
        else if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "2")
        {
            colliderManager.SetCollider2();
        }
        else if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "3")
        {
            colliderManager.SetCollider3();
        }
        else if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "4")
        {
            colliderManager.SetCollider4();
        }
        else if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "5")
        {
            colliderManager.SetCollider5();
        }
        else if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "6")
        {
            colliderManager.SetCollider6();
        }
        else if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "7")
        {
            colliderManager.SetCollider7();
        }


    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
