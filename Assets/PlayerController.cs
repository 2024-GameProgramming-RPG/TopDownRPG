<<<<<<< HEAD
using UnityEngine.InputSystem;
=======
>>>>>>> 73d2e2c (Chore:Player행동,애니메이션 추가)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
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
        this.animator.SetInteger("hp", 3);
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
        
        // if (true) // hp 0일떄
        // {
        //     this.animator.SetInteger("hp", 0);
        // }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Finish"){
            GameManager.EndGame();
        }
        else if (other.gameObject.tag == "Creature"){
            // hp 감소.
            this.animator.SetTrigger("creatureTrigger");
            // this.animator.SetInteger("hp", 0);
            //임시로 죽는거 해놓음
            // GameManager.EndGame();
        }
=======
    Rigidbody2D rigid2D;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1,0,0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1,0,0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0,1,0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0,-1,0);
        }

>>>>>>> 73d2e2c (Chore:Player행동,애니메이션 추가)
    }
}
