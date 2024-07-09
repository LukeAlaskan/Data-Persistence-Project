using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingBrick : Brick
{
    public GameObject explosionPrefab;

    void Start()
    {
        onStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnExplosion()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!isHit)
        {
            spawnExplosion();
            onHit();
        }

        isHit = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isHit)
        {
            spawnExplosion();
            onHit();
        }
        isHit = true;
    }
}
