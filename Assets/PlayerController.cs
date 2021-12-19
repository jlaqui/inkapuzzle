using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0f;
    public float maxSpeed = 3f;
    public float flag = 0f;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        if (Input.GetKey("d"))
        {
            transform.localScale = new Vector3(1, 1, 1);
            rigidbody2D.velocity = new Vector2(maxSpeed, rigidbody2D.velocity.y);
            flag = 2f;
            animator.SetFloat("Speed", flag);

        }

        else if (Input.GetKey("a"))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            rigidbody2D.velocity = new Vector2(-maxSpeed, rigidbody2D.velocity.y);
            flag = 2f;
            animator.SetFloat("Speed", flag);
        }

        else if (Input.GetKey("w"))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, maxSpeed);
            flag = 2f;
            animator.SetFloat("Speed", flag);
        }

        else if (Input.GetKey("s"))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, -maxSpeed);
            flag = 2f;
            animator.SetFloat("Speed", flag);
        }

        else
        {
            rigidbody2D.velocity = new Vector2(0, 0);
            flag = 0f;
            animator.SetFloat("Speed", flag);
        }
    }
}
