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
        if (other.gameObject.tag == "Player")
        {
            myMeshRenderer.material.color = Color.red;
            gameObject.tag = "Bumped";
        }
    }
}
