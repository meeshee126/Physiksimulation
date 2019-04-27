using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerManager : MonoBehaviour
{
    Ball m_ball;
    PhysicManager m_physic;
    CameraManager m_camera;
    Text m_uiControls;

    private void Start()
    {
        m_uiControls = GameObject.Find("TextControls").GetComponent<Text>();
        m_ball = GameObject.Find("Ball").GetComponent<Ball>();
        m_physic = GameObject.Find("PushObject").GetComponent<PhysicManager>();
        m_camera = GameObject.Find("Main Camera").GetComponent<CameraManager>();
    }

    /// <summary>
    /// List for all triggers in scene
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        // trigger for impuls
        if (other.name == "Ball" && this.gameObject.name == "PushTrigger")
        {
            m_physic.Push();
            Destroy(this.gameObject);
        }

        // changes camera offset through the simulation
        if (other.name == "Ball" && this.gameObject.name == "CameraTrigger")
        {
            m_camera.OffsetChanger();
            Destroy(this.gameObject);
        }

        // trigger for enable controls
        if (other.name == "Ball" && this.gameObject.name == "ControlTrigger")
        {
            m_uiControls.enabled = true;
            m_ball.m_controlsEnabled = true;
            m_camera.OffsetChanger();
            Destroy(this.gameObject);
        }

        // trigger for camera move and disable controls
        if (other.name == "Ball" && this.gameObject.name == "DominoTrigger")
        {
            m_uiControls.enabled = false;
            m_ball.m_controlsEnabled = false;
            m_camera.OffsetChanger();
            m_camera.StartCoroutine(m_camera.CameraSwitch());
            Destroy(this.gameObject);
        }
    }
}
