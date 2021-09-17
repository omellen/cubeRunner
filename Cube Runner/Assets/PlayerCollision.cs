using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement player;

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "Obstacle")
        {
            player.transform.SetPositionAndRotation(new Vector3(0, 1, 10), new Quaternion(0, 0, 0,0));
        } 
    }
}
