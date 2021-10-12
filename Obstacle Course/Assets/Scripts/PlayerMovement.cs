using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float xMovement = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zMovement = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMovement, 0, zMovement);
    }
}
