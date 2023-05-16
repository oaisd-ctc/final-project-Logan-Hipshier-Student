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
    void Start()
    {
        myrigidbody=GetComponent<Rigidbody2D>();
        myCollider=GetComponent<BoxCollider2D>();
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
            myrigidbody.velocity+= new Vector2(myrigidbody.velocity.x+1, JumpSpeed);
            Jumps++;
           
        }
    }
}
