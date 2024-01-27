using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Test : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ground")
        {
            Debug.Log(" Non-trigger Colliders entering collision");
        }
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.name == "Ground")
        {
            Debug.Log(" Non-trigger Colliders in collision");
        }
        
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Ground")
        {
            Debug.Log(" Non-trigger Colliders exits collision");
        }
    }
}
