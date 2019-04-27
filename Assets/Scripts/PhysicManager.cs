using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicManager : MonoBehaviour
{
    Rigidbody m_rb;

    [SerializeField]
    float m_pushPower, m_radius, m_explosionPower, m_upForce;

    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Function for giving a object a physical impulse
    /// </summary>
    public void Push()
    {
        m_rb.AddForce(Vector3.right * m_pushPower, ForceMode.Impulse);
    }

    /// <summary>
    /// Function for invoke the Explosion method in certain amount of time
    /// </summary>
    public void InvokeExplosion()
    {
        Invoke("Explosion", 1);
    }

    /// <summary>
    /// Function for giving a object a physical explosion
    /// </summary>
    public void Explosion()
    {
        // add all colliders which got a rigibody in this list
        Collider[] colliders = Physics.OverlapSphere(this.transform.position, m_radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            // all objects with a rigibody in the colliders list get an explosion impuls in his direction
            if (rb != null)
                rb.AddExplosionForce(m_explosionPower, this.transform.position, m_radius, m_upForce, ForceMode.Impulse);
        }

        Destroy(this.gameObject);
    }

    /// <summary>
    /// Function to show the radius it needds
    /// </summary>
    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(transform.position, radius);
    }
}
