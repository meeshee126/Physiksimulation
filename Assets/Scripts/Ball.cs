using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody m_rb;

    [SerializeField]
    float ballSpeed;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        m_rb.AddTorque(new Vector3(moveX, 0, moveZ) * ballSpeed * Time.deltaTime);
    }
}

