using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    Physic m_eObject;

    private void Start()
    {
        m_eObject = GameObject.Find("ExplosionObject").GetComponent<Physic>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            m_eObject.InvokeExplosion();
            Destroy(this.gameObject);
        }
    }
}
