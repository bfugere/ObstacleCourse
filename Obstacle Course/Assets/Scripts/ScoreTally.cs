using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTally : MonoBehaviour
{
    int numberOfCollisions = 0;

    void OnCollisionEnter(Collision other)
    {
        numberOfCollisions++;
        Debug.Log("You bumped into: " + numberOfCollisions + " object(s).");
    }
}
