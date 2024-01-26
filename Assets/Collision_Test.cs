using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Test : MonoBehaviour
{
    public bool Collided;
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(" Non-trigger Colliders entering collision");
        Collided = true;
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log(" Non-trigger Colliders in collision");
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log("Non-trigger Colliders exiting collision");
        Collided = false;
    }
}
