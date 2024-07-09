using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : Ball
{

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        float randomDirection = Random.Range(-1.0f, 1.0f);
        Vector3 forceDir = new Vector3(randomDirection, 1, 0);
        forceDir.Normalize();

        transform.SetParent(null);
        m_Rigidbody.AddForce(forceDir * 2.0f, ForceMode.VelocityChange);
    }

}
