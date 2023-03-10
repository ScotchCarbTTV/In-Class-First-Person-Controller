using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rbody;

    [SerializeField] private Vector3 ballVelocity; //value determining the direction and speed which the ball is travelling at
    [SerializeField] float ballSpeed; // value determining how fast the ball should travel

    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<Rigidbody>(out rbody))
        {
            Debug.LogError("No rigidbody attached to ball!");
            
        }
        //else, set the starting velocity randomly to left or right
        else
        {
            rbody.velocity = ballVelocity * ballSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //on each frame keep the ball's speed at the speed value (to prevent slowing down)
        
        rbody.velocity = ballVelocity * ballSpeed;

        //DEBUGGING
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            float newX = ballVelocity.x * -1;
            ballVelocity = new Vector3(newX, ballVelocity.y, 0).normalized;            
        }       
        
    }

    //method for setting velocity
    public void SetVelocity(float dirX, float dirZ, float spinVal)
    {
        //takes in a variable for x axis & apply to ballVelocity
        float newX = ballVelocity.x * dirX;
        float newZ = ballVelocity.z * dirZ;

        ballVelocity = new Vector3(newX, 0, newZ);
    }
    
    //takes in a variable for y axis
    //takes in a variable for 'spin'
    //if spin isn't zero, the y axis velocity will be adjusted by that value after being randomly adjusted/tweaked
    //calculates a random amount to adjust the y axis velocity by

    private void OnCollisionEnter(Collision collision)
    {
        //if collision is a paddle...
        if(collision.gameObject.TryGetComponent<Paddle>(out Paddle pdl))
        {
            //flip the x velocity of the ball by multiplying by -1
            SetVelocity(-1, 1, 0);
        }
        //if it isn't a paddle, check if it's a wall
        else if(collision.gameObject.tag == "topbottom")
        {
            SetVelocity(1, -1, 0);
        }
        else if(collision.gameObject.tag == "leftWall")
        {
            Debug.Log("Right player scored!");
            SetVelocity(-1, 1, 0);
        }
        else if (collision.gameObject.tag == "rightWall")
        {
            Debug.Log("Left player scored!");
            SetVelocity(-1, 1, 0);
        }
        //if it's the top or bottom wall then change the velocity of the ball so that the Y axis is inverted
        //if it's the left wall add a point to right paddle and use the reset method, passing it 'right' as the start direction
        //if it's the right wall add a point to left paddle and use the reset method, passing it 'left' as the start direction
    }

}
