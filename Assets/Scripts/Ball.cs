using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody m_rb;

    [SerializeField]
    float m_ballSpeed;

    public bool m_controlsEnabled;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (m_controlsEnabled)
        {
            Movement();
        }
    }

    public void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        m_rb.AddTorque(new Vector3(moveX, 0, moveZ) * m_ballSpeed * Time.deltaTime);
    }
}

