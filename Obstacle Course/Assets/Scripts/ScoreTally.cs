using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTally : MonoBehaviour
{
    int numberOfCollisions = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Bumped")
        {
            numberOfCollisions++;
            Debug.Log(gameObject + " bumped into " + numberOfCollisions + " object(s).");
        }
    }
}
