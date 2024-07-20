using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rbody;
    public Vector2 moveDir;
    public float moveSpeed;
    [SerializeField] private Transform playerLookAt;

    void Update()
    {
        moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveDir.Normalize();

        playerLookAt.right = -moveDir;

        Debug.DrawRay(transform.position, playerLookAt.up, Color.yellow);
        Debug.DrawRay(transform.position, -playerLookAt.up, Color.red);
        Debug.DrawRay(transform.position, moveDir, Color.green);
    }

    void FixedUpdate()
    {
        rbody.MovePosition(rbody.position + moveDir * moveSpeed);
    }
}
