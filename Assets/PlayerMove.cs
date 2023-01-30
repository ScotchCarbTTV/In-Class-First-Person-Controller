using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speed = 5;
    [SerializeField] private float turnSpeed = 5;
    [SerializeField] private float jumpForce = 5;

    [SerializeField] Rigidbody rbody;

    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        //check if the player is pressing W
        if (Input.GetKey("w"))
        {
            //move in the direction the player is facing
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if(Input.GetKey("s"))
        {
            //move in the opposite direction the player is facing
            transform.position += -transform.forward * speed * Time.deltaTime;
        }

        //check if the player is pressing q or e
        if (Input.GetKey("q"))
        {
            //rotate the player left or right
            transform.Rotate(-transform.up * turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("e"))
        {
            //rotate the player left or right
            transform.Rotate(transform.up * turnSpeed * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (grounded == true)
            {
                rbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
                grounded = false;
            }
        }      

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }
}
