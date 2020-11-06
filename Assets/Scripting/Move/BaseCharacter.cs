using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseCharacter : MonoBehaviour
{
    int numPath;

    public virtual void Move(Vector3 move, Rigidbody rb){
        rb.velocity = move;
    }

    public virtual void AiMove(NavMeshAgent agent, int numpath, GameObject[] paths, GameObject ghost) {

        numPath = numpath;

        if(numPath < paths.Length){
            if(Vector3.Distance(paths[numPath].transform.position, ghost.transform.position) < 1)
            {
                if(numPath == paths.Length - 1)
                    numPath = 0;
                else
                    numPath++;
            }
        }

        agent.SetDestination(paths[numPath].transform.position);
    }

    public virtual void AnimationFloat(Animator anim, string name ,float value) {
        anim.SetFloat(name, value);
    }

    public virtual void AnimationBool(Animator anim, string name, bool decision) {
        anim.SetBool(name, decision);
    }

    public virtual void AnimationTrigger(Animator anim, string name) {
        anim.SetTrigger(name);
    }

    public virtual void Damage(float damageDealer, float damageObject) {
        damageObject -= damageDealer;
    }

    public virtual void LookAt(GameObject Ai) {
       Ai.transform.rotation = Quaternion.Lerp(Ai.transform.rotation, GameObject.Find("Player").transform.rotation, .2f); 
    }
}
