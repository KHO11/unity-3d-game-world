using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

   
   static Animator anim;
    public float speed = 10.0f;
    public float rotationSpeed = 10.0f;
   
    public Rigidbody rb;
    public float jumpHeight = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
  
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

       
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);



        if (Input.GetKey(KeyCode.W)) {
            anim.SetBool("isWalking", true);
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
           
        }

        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("walkBack", true);
            rb.AddForce(0, 0, -500 * Time.deltaTime);

        }

        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("walkBack", false);
        }

        
        
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
            
            
        }

        else
        {
            anim.SetBool("isJumping", false);
        }

        if (Input.GetKey(KeyCode.B))
        {
            anim.SetBool("jumpForward", true);
        }

        else
        {
            anim.SetBool("jumpForward", false);
        }






    }


}
