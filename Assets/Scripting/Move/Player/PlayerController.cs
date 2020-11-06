using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseCharacter
{
    Rigidbody rb;
    [SerializeField] float speedMove, lookSpeed, dst;
    [SerializeField] LayerMask teract;
    private Animator playerAnim;
    [SerializeField] Transform rayPost;
    private RaycastHit hit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        RayObejct();

        if(Input.GetKeyDown(KeyCode.Z))
            LookAt(hit.collider.gameObject);
    }

    void Move() {
        Vector2 v2 = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 v3 = new Vector3(v2.x, 0, v2.y) * Time.deltaTime * speedMove;

        Move(v3, rb);
        AnimationFloat(playerAnim, "walk", v3.sqrMagnitude);

        if(v3 != Vector3.zero){
            transform.rotation = Quaternion.Normalize(Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(v3), Time.deltaTime * lookSpeed));
        }
    }

    private void RayObejct() {
        Ray ray = new Ray(rayPost.transform.position, rayPost.transform.forward);
    
        if(Physics.Raycast(ray, out hit, dst, teract)){
            var interact = hit.collider.GetComponent<Iinteractable>();

            if(Input.GetKeyDown(KeyCode.LeftShift)){
                if(interact != null)
                    interact.Interact();

                SkillController.gm_Instance.UseSkill(hit);
            }
        }
    }
}
