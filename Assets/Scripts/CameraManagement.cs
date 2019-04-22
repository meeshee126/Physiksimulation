using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagement : MonoBehaviour
{
    [SerializeField]
    GameObject m_ball;

    [SerializeField]
    float m_xOffset, m_yOffset, m_zOffset;

    void FixedUpdate()
    {
        Vector3 offset = new Vector3(m_xOffset, m_yOffset, m_zOffset);
      
        transform.position = m_ball.transform.position + offset;
        transform.LookAt(m_ball.transform.position);
    }
}
