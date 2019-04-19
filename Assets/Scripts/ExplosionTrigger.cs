using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    ExplosionObject m_eObject;

    private void Start()
    {
        m_eObject = GameObject.Find("ExplosionObject").GetComponent<ExplosionObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            Debug.Log("sdd");
            m_eObject.Push();
        }
    }
}
