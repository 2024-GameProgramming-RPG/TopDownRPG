using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 movementInput;
    Rigidbody2D rigid2D;
    Animator animator;
    SpriteRenderer rend;
    // Start is called before the first frame update
    public float moveSpeed = 1f; 
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }
    void Update()
    {
        Vector2 movement = movementInput * moveSpeed * Time.fixedDeltaTime;
        rigid2D.MovePosition(rigid2D.position + movement);

        if (movementInput != Vector2.zero)
        {
            this.animator.SetBool("isWalking", true);

            if (movementInput.x != 0)
                rend.flipX = movementInput.x < 0;
        }
        else
        {
            this.animator.SetBool("isWalking", false);
        }
        
        if (true) // hp 0일떄
        {
            this.animator.SetInteger("hp", 0);
        }
    }
}
