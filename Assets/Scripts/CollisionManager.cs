using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    PhysicManager m_physic;
    CameraManager m_camera;

    private void Start()
    {
        m_camera = GameObject.Find("Main Camera").GetComponent<CameraManager>();
        m_physic = GameObject.Find("Bomb").GetComponent<PhysicManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // invokes explosion when the last domino stone collide with the bomb
        if (collision.gameObject.tag == "DominoStone")
        {
            // disable camera script for standing still
            m_camera.enabled = false;
            m_physic.InvokeExplosion();
        }
    }
}
