using UnityEngine;
public class UpdateCollider : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {    
        ColliderManager colliderManager = GameObject.FindWithTag("Bird").GetComponent<ColliderManager>();

        Debug.Log($"{animator.GetCurrentAnimatorClipInfo(0)[0].clip.name}");
        
        if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "JumpUp")
        {
            colliderManager.SetColliderJumpUp();
        }
        else if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "JumpDown")
        {
            colliderManager.SetColliderJumpDown();
        }
        else
        {
            colliderManager.SetColliderJumpOn();
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       // Implement code that processes and affects root motion
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       // Implement code that sets up animation IK (inverse kinematics)
    }
}
