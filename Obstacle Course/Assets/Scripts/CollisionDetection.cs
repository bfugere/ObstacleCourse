using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    MeshRenderer myMeshRenderer;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + " collided with " + name);
        myMeshRenderer.material.color = Color.red;
    }
}