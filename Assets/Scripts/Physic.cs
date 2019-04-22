using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physic : MonoBehaviour
{

    Rigidbody m_rb;

    [SerializeField]
    float m_pushPower, m_radius, m_explosionPower, m_upForce;

    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    public void Push()
    {
        m_rb.AddForce(Vector3.right * m_pushPower, ForceMode.Impulse);
    }

    public void InvokeExplosion()
    {
        Invoke("Explosion", 2);
    }

    public void Explosion()
    {
        Collider[] colliders = Physics.OverlapSphere(this.transform.position, m_radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(m_explosionPower, this.transform.position, m_radius, m_upForce, ForceMode.Impulse);
        }

        Destroy(this.gameObject);
    }

    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(transform.position, radius);
    }
}
