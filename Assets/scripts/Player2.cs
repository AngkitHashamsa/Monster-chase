using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float JumpForce = 11f;

    private float movementx;
    private Rigidbody2D mybody;
    private SpriteRenderer SpriteRenderer;
    private Animator anim;
    private string WALK_ANIMATION = "walk";

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveOnKeyBoardEnter();
        AnimationAnimation();
        PlayerJump();
    }

    void MoveOnKeyBoardEnter()
    {
        movementx = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementx,0f,0f) * moveForce * Time.deltaTime;
    }

    void AnimationAnimation()
    {
        if(movementx > 0f)
        {
            anim.SetBool(WALK_ANIMATION, true);
            SpriteRenderer.flipX = false;
        }
        else if ( movementx < 0f)
        {
            anim.SetBool(WALK_ANIMATION, true);
            SpriteRenderer.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
       
    }
    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            mybody.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }
    }

}
