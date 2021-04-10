using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticProperties : MonoBehaviour
{
    public float minTexOffset, maxTexOffset;

    public static float minOffset = -1.0f;
    public static float maxOffset = -1.0f;

    private void Awake()
    {
        minOffset = minTexOffset;
        maxOffset = maxTexOffset;
    }
}
