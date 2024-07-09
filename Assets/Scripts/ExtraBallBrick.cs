using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBallBrick : Brick
{
    public GameObject ballPrefab;

    
    // Start is called before the first frame update
    void Start()
    {
   
        onStart();
    }

    private void spawnBall()
    {
        Instantiate(ballPrefab, transform.position, transform.rotation);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!isHit)
        {
            spawnBall();
            onHit();
        }

        isHit = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isHit)
        {
            spawnBall();
            onHit();
        }
        isHit = true;
    }
}
