using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagement : MonoBehaviour
{
    [SerializeField]
    GameObject m_ball;

    [SerializeField]
    float m_lerpSpeed,m_xOffset, m_yOffset, m_zOffset;

    int m_cameraPosition = 1;

    void FixedUpdate()
    {    
        Vector3 offset = new Vector3(m_xOffset, m_yOffset, m_zOffset);
        Vector3 lerp = Vector3.Lerp(transform.position, m_ball.transform.position + offset, m_lerpSpeed * Time.deltaTime);
        transform.position = lerp;
        transform.LookAt(m_ball.transform.position);

    }

    /// <summary>
    /// Changes camera offset through tiggers
    /// </summary>
    public void OffsetChanger()
    {      
        if (m_cameraPosition == 1)
        {
            m_yOffset = 7;
           
        }

        if (m_cameraPosition == 2)
        {
            m_xOffset = -8;
            m_zOffset = 0;
        }

        m_cameraPosition++;
    }
}
