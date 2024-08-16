using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
    public Rigidbody2D MyRigdbody;

    public Vector2 Velocity;

    public float Speed;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MyRigdbody.velocity = new Vector2(-Speed, MyRigdbody.velocity.y);

        }
        else if (Input.GetKeyDown (KeyCode.RightArrow))
        {
            MyRigdbody.velocity = new Vector2(Speed, MyRigdbody.velocity.y);
        }
    }
}
