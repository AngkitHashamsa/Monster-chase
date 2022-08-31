using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumForce = 12f;

    private float movementX;
    private Rigidbody2D myBody;
    private Animator anim;
    private SpriteRenderer sprite;
    private string WALK_ANIMATION = "walk";
    private bool isGrounded = true;
    private string GROUND_TAG = "ground";
    private string ENEMY_TAG = "enemy";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();

    }

    //private void FixedUpdate()
    //{
    //    PlayerJump();
    //}

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += moveForce * Time.deltaTime * new Vector3(movementX, 0f, 0f);

    }

    void AnimatePlayer()

    {
        
       
        if(movementX > 0f)
        {

            // pressed d = +ve x axis so +1
            anim.SetBool(WALK_ANIMATION, true);
            sprite.flipX = false;
        }
      
      else  if(movementX < 0f)
      
        {
            // pressed a = -ve x axis so -1
            anim.SetBool(WALK_ANIMATION, true);
            sprite.flipX = true;
        }
        else
        {
            //when key not pressed the value of movemnet x is 0
            anim.SetBool(WALK_ANIMATION, false);
        }

    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded )
        {
            isGrounded = false;
            myBody.AddForce(new Vector3(0f,jumForce,0f), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }

    //with is trigger switch on tag
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(ENEMY_TAG))
            Destroy(gameObject);

    }

}//class


