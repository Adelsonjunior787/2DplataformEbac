using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
    public Rigidbody2D MyRigdbody;

    public Vector2 Friction = new Vector2(-1, 0);

    public float Speed;

    public float forceJump = 5;

    public float SpeedRun;

    private float _currentSpeed;

    private void Update()
    {
        HandleJump();
        HandleMoviment();  
    }

    private void HandleMoviment()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            _currentSpeed = SpeedRun;
        else
            _currentSpeed = Speed;

        if (Input.GetKey(KeyCode.A))
        {
            MyRigdbody.velocity = new Vector2(-_currentSpeed, MyRigdbody.velocity.y);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            MyRigdbody.velocity = new Vector2(_currentSpeed, MyRigdbody.velocity.y);
        }

        if (MyRigdbody.velocity.x > 0)
        {
            MyRigdbody.velocity += Friction;
        }
        else if(MyRigdbody.velocity.x < 0)
        {
            MyRigdbody.velocity -= Friction;
        }      
    }

    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            MyRigdbody.velocity = Vector2.up * forceJump;
    }


}
