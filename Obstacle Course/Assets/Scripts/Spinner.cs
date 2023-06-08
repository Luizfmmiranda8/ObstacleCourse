using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    #region VARIABLES
    [Header("Rotation speed")]
    [SerializeField] float rotationXSpeed = 0f;
    [SerializeField] float rotationYSpeed = 1f;
    [SerializeField] float rotationZSpeed = 0f;
    #endregion

    #region EVENTS
    void Update()
    {
        RotateObject();
    }
    #endregion

    #region METHODS
    void RotateObject()
    {
        transform.Rotate(rotationXSpeed, rotationYSpeed, rotationZSpeed);
    }
    #endregion
}
