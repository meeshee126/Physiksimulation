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
        // moving ball when controls are enabled
        if (m_controlsEnabled)
        {
            Movement();
        }
    }

    public void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // control the ball using torsion / torque
        m_rb.AddTorque(new Vector3(moveX, 0, moveZ) * m_ballSpeed * Time.deltaTime);
    }
}

