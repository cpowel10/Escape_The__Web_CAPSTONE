using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;
    private Rigidbody2D rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            rbPlayer.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbPlayer.velocity.y);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"),0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x , Input.GetAxisRaw("Vertical") * moveSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f,Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            rbPlayer.velocity = new Vector2(0f, rbPlayer.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x,0f);
        }

        anim.SetFloat("Move_X", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("Move_Y", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving",playerMoving);
        anim.SetFloat("LastMoveX",lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }
}
