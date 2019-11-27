using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JitterFix : MonoBehaviour
{
    public bool simulateJitter = false;
    public bool jitterSmoothFix = false;
    public float smoothTime = 1f;
    public float jitterMagnitude = 0.2f;

    private Vector3 velocity = Vector3.zero;
    Vector2 targetPos;
    Transform tf;

    void Start()
    {
        simulateJitter = false;
        jitterSmoothFix = false;
        targetPos = Vector2.zero;
        tf = GetComponent<Transform>();
    }

    
    void Update()
    {
        if (simulateJitter)
        {
            JitterShuffle();
            if (jitterSmoothFix)
            {
                tf.position = Vector3.SmoothDamp(tf.position, new Vector3(targetPos.x, 0, targetPos.y), ref velocity, smoothTime);
            }
            else
            {
                tf.position = new Vector3(targetPos.x, 0, targetPos.y);
            }
            
        }
        else
        {
            targetPos = Vector2.zero;
            tf.position = new Vector3(targetPos.x, 0, targetPos.y);
        }


    }

    void JitterShuffle()
    {
        targetPos = Random.onUnitSphere * jitterMagnitude;
    }


}
