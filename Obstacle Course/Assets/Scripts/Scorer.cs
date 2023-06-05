using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    #region VARIABLES
    int hits = 0;
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
        hits++;
        Debug.Log("You bumped into a thing this many times: " + hits);
    }
    #endregion
}
