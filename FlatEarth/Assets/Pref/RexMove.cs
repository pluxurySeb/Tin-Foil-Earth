using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Name
{
    public class RexMove : MonoBehaviour
{
     public Vector3 jump;
    public float jumpForce = 20.0f;

    public bool isGrounded;
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
    }

    void OnCollisionStay(){
        isGrounded = true;
    }
    public float Speed;
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
     if(VirtualInputManager.Instance.MoveRight){
         this.gameObject.transform.Translate(Vector3.forward * 7f * Time.deltaTime);
         this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        
     }   
      if(VirtualInputManager.Instance.MoveLeft){
         this.gameObject.transform.Translate(Vector3.forward * 7f * Time.deltaTime);
        this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
     }   
    }
}
}
