using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    private Vector2 velocity;

    [SerializeField]
    private float moveVelocity,maxVelocity,velocityIncreaseRate;  

    [SerializeField]
    private ButtonHandler btnhandler;  

    void Start ()
    {
        velocity = new Vector2(moveVelocity,0);
       
    }


    void FixedUpdate()
    {
        if(moveVelocity < maxVelocity)
        {
            moveVelocity += velocityIncreaseRate * Time.deltaTime;
        }


        if(Input.GetKey(KeyCode.D))
        {
            MoveLeft();
        }

        if(btnhandler.ltbtnHolded == true)
        {
            MoveLeft();
        }


        if(Input.GetKey(KeyCode.A))
        {
            MoveRight();
        }

        if(btnhandler.rtbtnHolded == true)
        {
            MoveRight();
        }
    }

    void MoveLeft()
    {
        _rigidbody.MovePosition(_rigidbody.position + velocity * Time.fixedDeltaTime);
    }

    void MoveRight()
    {
        _rigidbody.MovePosition(_rigidbody.position - velocity * Time.fixedDeltaTime);
    }

}
