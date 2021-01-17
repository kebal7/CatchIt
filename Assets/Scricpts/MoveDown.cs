using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private float yVelocity,maxyVelocity,velocityIncreaseRate;

    void FixedUpdate()
    {
        if(yVelocity < maxyVelocity)
        {
            yVelocity += velocityIncreaseRate * Time.deltaTime;
        }
        _rigidbody.velocity = new Vector2(0, -yVelocity);
    }
}
