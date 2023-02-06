using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //variable for the paddle speed
    [SerializeField] float speed;

    //variable determining if this is left or right paddle
    [SerializeField] bool isLeftPaddle;

    //variable for rigid body
    private Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        //automatically assign the rigidbody with trygetcomponent
        if(!TryGetComponent<Rigidbody>(out rbody))
        {
            //disable the object if it has no rigidbody
            Debug.LogError("There is no rigidbody attached to this paddle!");
            gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //check if this is the left paddle
        if (isLeftPaddle)
        {
            //check if the player is pressing W
            if (Input.GetAxisRaw("VerticalLeft") > 0)
            {
                //move paddle north if they are pressing W
                rbody.AddForce(0, 0, speed);
            }
            //check if the player is holding S
            else if(Input.GetAxisRaw("VerticalLeft") < 0)
            {
                //move paddle south if they are holding S
                rbody.AddForce(0, 0, -speed);
            }
            else
            {
                rbody.velocity = Vector3.zero;
            }
            
        }
        else
        {
            if (Input.GetAxisRaw("VerticalRight") > 0)
            {                
                rbody.AddForce(0, 0, speed);
            }
            
            else if (Input.GetAxisRaw("VerticalRight") < 0)
            {
                
                rbody.AddForce(0, 0, -speed);
            }
            else
            {
                rbody.velocity = Vector3.zero;
            }
        }


        //check if this is the right paddle
        //check if the player is pressing up arrow
        //move paddle north if they are pressing up arrow
        //check if the player is holding down arrow
        //move paddle south if they are holding down arrow

    }
}
