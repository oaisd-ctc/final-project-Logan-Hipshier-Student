using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isAlive;
    BoxCollider2D myCollider;
    private void Awake()
    {
        isAlive = true;
        myCollider = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (myCollider.IsTouchingLayers(LayerMask.GetMask("Death"))){
            isAlive = false;
        }
    }
    public bool getAlive()
    {
        return isAlive;
    }
    
}
