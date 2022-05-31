using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    private bool facingRight = true;
    public AudioSource footstep;

    public Rigidbody rigidbody;
    public float playerSpeed = 10;

    float horizontal;
    float vertical;
    public void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (horizontal > 0 && facingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (horizontal < 0 && !facingRight)
        {
            // ... flip the player.
            Flip();
        }
    }
    public void FixedUpdate()
    {
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rigidbody.MovePosition(rigidbody.position + movement * Time.deltaTime * playerSpeed);
    }
   
    private void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale; ;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void Footstep()
    {
        footstep.Play();
    }
}
