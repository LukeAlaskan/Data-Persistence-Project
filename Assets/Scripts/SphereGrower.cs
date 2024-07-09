using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGrower : MonoBehaviour
{
    // Duration over which the sphere will grow (in seconds)
    public float growTime = 5f;

    // Final scale of the sphere
    public Vector3 finalScale = new Vector3(2f, 2f, 2f);

    // Internal variables to track time and initial scale
    private float elapsedTime = 0f;
    private Vector3 initialScale;

    void Start()
    {
        // Store the initial scale of the sphere
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Increment the elapsed time
        elapsedTime += Time.deltaTime;

        // Calculate the interpolation factor (from 0 to 1)
        float t = Mathf.Clamp01(elapsedTime / growTime);

        // Linearly interpolate the scale of the sphere
        transform.localScale = Vector3.Lerp(initialScale, finalScale, t);

        // Optionally, stop updating after the grow time has elapsed
        if (elapsedTime >= growTime)
        {
            // This line is optional to ensure no further updates after reaching the final scale
            Destroy(gameObject);
        }
    }
}

