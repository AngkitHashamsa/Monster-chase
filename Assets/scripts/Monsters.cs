using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;
    //private SpriteRenderer sr;
    //private Animator animator;


    private void Awake()
    {
        //animator = GetComponent<Animator>();
        //sr = GetComponent<SpriteRenderer>();
        myBody = GetComponent<Rigidbody2D>();
        //speed = 3;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }
}//class
