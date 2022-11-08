using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{

    [SerializeField] 
    private GameObject TurretPrefab;

    [SerializeField] 
    private Vector3 SpawnRay = Vector3.down;
    private Vector3 SpawnDirection = Vector3.forward;
    private Vector3 RayHit;


    private GameObject TurretInstance;
    
    [ContextMenu("SpawnTurret")]
    void SpawnTurret()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(SpawnRay.normalized) * 100f, out RaycastHit hitInfo))
        {
            RayHit = hitInfo.point;
            
        }

        if (RayHit != null)
        {
            TurretInstance = Instantiate(TurretPrefab, RayHit, Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        // Gizmos.color = Color.blue;
        // Gizmos.DrawLine(transform.position, RayHit);
        
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.TransformDirection(SpawnRay.normalized) * 100f);
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(RayHit, Vector3.one * 0.1f );
        
        Gizmos.color = Color.red;
        Gizmos.DrawRay(RayHit, SpawnDirection);
        Gizmos.DrawWireSphere(RayHit, 1f);
    }

    private void Start()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(SpawnRay.normalized) * 100f, out RaycastHit hitInfo))
        {
            RayHit = hitInfo.point;
        }
    }

    void Update()
    {
        
    }
}
