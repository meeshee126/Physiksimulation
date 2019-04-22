using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTrigger : MonoBehaviour
{
    Physic m_pObject;

    private void Start()
    {
        m_pObject = GameObject.Find("PushObject").GetComponent<Physic>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            Debug.Log("sdd");
            m_pObject.Push();
        }      
    }
}
