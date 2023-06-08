using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    #region VARIABLES
    #endregion

    #region EVENTS
    void OnCollisionEnter(Collision other) 
    {
        StartCollision(other);
    }
    #endregion

    #region METHODS
    void StartCollision(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
    #endregion
}
