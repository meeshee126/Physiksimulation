using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{
    Rigidbody m_rb;

    [SerializeField]
    float m_momentumPower;

    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    public void Push()
    {
        m_rb.AddForce(Vector3.right * m_momentumPower, ForceMode.Impulse);
    }
}
