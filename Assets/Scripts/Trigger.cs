using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    Ball m_ball;
    Physic m_pushObject;
    CameraManagement m_camera;
    Text m_uiControls;

    private void Start()
    {
        m_uiControls = GameObject.Find("TextControls").GetComponent<Text>();
        m_ball = GameObject.Find("Ball").GetComponent<Ball>();
        m_pushObject = GameObject.Find("PushObject").GetComponent<Physic>();
        m_camera = GameObject.Find("Main Camera").GetComponent<CameraManagement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball" && this.gameObject.name == "PushTrigger")
        {
            m_pushObject.Push();
            Destroy(this.gameObject);
        }

        if (other.name == "Ball" && this.gameObject.name == "CameraTrigger")
        {
            m_camera.OffsetChanger();
            Destroy(this.gameObject);
        }

        if (other.name == "Ball" && this.gameObject.name == "ControlTrigger")
        {
            m_uiControls.enabled = true;
            m_ball.m_controlsEnabled = true;
            m_camera.OffsetChanger();
            Destroy(this.gameObject);
        }
    }
}
