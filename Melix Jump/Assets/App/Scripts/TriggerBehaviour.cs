using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    [SerializeField] Transform platformTransform;
    
    private Vector3 explosionPosition ;
    [SerializeField] private float explosionPower = 5f;
    [SerializeField] private float explosionRadius = 2f;

    private void Start()
    {
        explosionPosition = platformTransform.position;

        explosionPosition.y -= 0.5f;
    }
    private void OnTriggerExit(Collider other)
    {
        
      

        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                rb.useGravity = true;
                
                rb.AddExplosionForce(explosionPower, explosionPosition, explosionRadius);

            }
        }

        Debug.Log("Explosion Happened!!");  
    }
}
