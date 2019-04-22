using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    Rigidbody m_rb;
    public float speed;

    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.AddTorque(transform.position * speed, ForceMode.Impulse);
    }
}
