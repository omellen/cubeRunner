using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public float forwardForce = 2000f;

    private void FixedUpdate()
    {
        rigid.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rigid.AddForce(400f * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            rigid.AddForce(-400f* Time.deltaTime, 0, 0);
        }
    }
}
