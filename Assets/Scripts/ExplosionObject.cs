using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionObject : MonoBehaviour
{
   

    public float radius;
    public float power;
    public float upForce;


    void Start()
    {
       
    }

    public void Push()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, upForce);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, radius);
    }
}
