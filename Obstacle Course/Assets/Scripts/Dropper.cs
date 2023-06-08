using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    #region VARIABLES
    [Header("Time")]
    [SerializeField] float timeToWait = 5f;

    [Header("Components")]
    MeshRenderer dropperMeshRenderer;
    Rigidbody dropperRigidbody;
    #endregion

    #region EVENTS
    void Awake() 
    {
        dropperMeshRenderer = GetComponent<MeshRenderer>();
        dropperRigidbody = GetComponent<Rigidbody>();
    }

    void Start() 
    {
        dropperMeshRenderer.enabled = false;
        dropperRigidbody.useGravity = false;
    }

    void Update() 
    {
        DropObject();
    }
    #endregion

    #region METHODS
    void DropObject()
    {
        if(Time.time > timeToWait)
        {
            dropperMeshRenderer.enabled = true;
            dropperRigidbody.useGravity = true;
        }
    }
    #endregion
}
