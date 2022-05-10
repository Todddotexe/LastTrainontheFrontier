using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float playerSpeed = 5;

    float horizontal;
    float vertical;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rigidbody.MovePosition(rigidbody.position + movement * Time.deltaTime * playerSpeed);
    }
}
