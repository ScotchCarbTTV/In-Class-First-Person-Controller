using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<Rigidbody>(out rbody))
        {
            Debug.LogError("No rigidbody attached to ball!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if collision is a paddle...
        if(collision.gameObject.try)
    }

}
