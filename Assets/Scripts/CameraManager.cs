using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_ball;

    [SerializeField]
    float m_lerpSpeed, m_cameraSpeed, m_xOffset, m_yOffset, m_zOffset;

    // count for offset changer
    public int m_cameraPosition = 1;

    public bool m_followBall = true;

    void FixedUpdate()
    {
        // camera follows the ball
        if (m_followBall)
        {
            FollowBall();
        }

        // after reaching domino path camera follows the stones
        else
        {
            FollowDomino();
        }
    }

    /// <summary>
    /// Function for following the ball with a lerp
    /// </summary>
    public void FollowBall()
    {
        Vector3 offset = new Vector3(m_xOffset, m_yOffset, m_zOffset);

        // smooth camera movement + offset
        Vector3 lerp = Vector3.Lerp(transform.position, m_ball.transform.position + offset, m_lerpSpeed * Time.deltaTime);

        transform.position = lerp;

        // ball is allways in the center of the camerea
        transform.LookAt(m_ball.transform.position);
    }

    /// <summary>
    /// Function for the domino path
    /// </summary>
    public void FollowDomino()
    {
        transform.Translate(Vector3.right * m_cameraSpeed * Time.deltaTime);
    }

    /// <summary>
    /// after triggering domino path the camera should wait a certain amount of time to move with the domino stones
    /// </summary>
    /// <returns></returns>
    public IEnumerator CameraSwitch()
    {
        yield return new WaitForSeconds(1);
        m_followBall = false;
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

        if (m_cameraPosition == 3)
        {
            m_xOffset = 0;
            m_zOffset = -10;
        }

        m_cameraPosition++;
    }
}
