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
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    #endregion
}
