using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownShooter : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.x == 0 && movement.y == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if (movement.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else if (movement.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


}
