using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTally : MonoBehaviour
{
    int numberOfCollisions = 0;

    Text bumpText;

    void Start()
    {
        bumpText = GameObject.Find("Canvas/bumpText").GetComponent<Text>();
        UpdateBumpText();
    }

    void Update()
    {
        UpdateBumpText();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Bumped")
        {
            numberOfCollisions++;
            UpdateBumpText();
            Debug.Log(gameObject + " bumped into " + numberOfCollisions + " object(s).");
        }
    }

    void UpdateBumpText()
    {
        bumpText.text = "Bumps: " + numberOfCollisions.ToString();
    }
}
