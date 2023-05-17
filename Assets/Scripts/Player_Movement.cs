using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float JumpSpeed;
    Rigidbody2D myrigidbody;
    Vector2 moveInput;
    BoxCollider2D myCollider;
    int Jumps;
    float JumpConst;
    void Start()
    {
        myrigidbody=GetComponent<Rigidbody2D>();
        myCollider=GetComponent<BoxCollider2D>();
        JumpConst=JumpSpeed;
    }

    
    void Update()
    { 
        if(myCollider.IsTouchingLayers(LayerMask.GetMask("Ground"))){
            Jumps = 0;
        }
        
        Vector2 Move= new Vector2(moveSpeed,myrigidbody.velocity.y);
        myrigidbody.velocity= Move;


    }
    
    void OnJump(InputValue value){
        if(value.isPressed && Jumps<1){
            if(!myCollider.IsTouchingLayers(LayerMask.GetMask("Ground"))){
                JumpSpeed = JumpConst+ 0.5f;
            }
            myrigidbody.AddForce(Vector2.up*JumpSpeed,ForceMode2D.Impulse);
            //myrigidbody.velocity+= new Vector2(12, JumpSpeed);
            Jumps++;
            JumpSpeed=JumpConst;
           
        }
    }
}
