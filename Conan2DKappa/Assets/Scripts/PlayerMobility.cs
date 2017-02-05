using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {

    public float speed;

    Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //Physics updates
    void FixedUpdate () {
        var move =new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }
    //Not physics updates
    void Update()
    {
        animationStopCheck();
        //up
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("moveUp");
        }
        //down
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("moveDown");
        }
        //left
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("moveLeft");
        }
        //right
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("moveRight");
        }
    }
    void animationStopCheck()
    {
        //up
        if (!Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("stopUp");
        }
        //down
        if (!Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("stopDown");
        }
        //left
        if (!Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("stopLeft");
        }
        //right
        if (!Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("stopRight");
        }
    }
	
    
}
