using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTimer = 3f;
    
    Rigidbody myRigidbody;
    MeshRenderer myMeshRenderer;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();

        myRigidbody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    void Update()
    {
        DropObject();
    }

    void DropObject()
    {
        if (myMeshRenderer.enabled == false && Time.time > dropTimer)
        {
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}
