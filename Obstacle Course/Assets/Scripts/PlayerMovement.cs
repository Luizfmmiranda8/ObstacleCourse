using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region VARIABLES
    [Header("Movement")]
    [SerializeField] float moveSpeed = 1f;
    #endregion

    #region EVENTS
    void Start() 
    {

    }

    void Update() 
    {
        MovePlayer();
    }
    #endregion

    #region METHODS
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
    #endregion
}
