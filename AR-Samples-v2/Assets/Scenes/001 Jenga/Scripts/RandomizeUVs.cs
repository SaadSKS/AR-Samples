using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeUVs : MonoBehaviour
{
    MaterialPropertyBlock propertyBlock;

    void Awake()
    {
        if (propertyBlock == null)
            propertyBlock = new MaterialPropertyBlock();

        Renderer renderer = GetComponentInChildren<Renderer>();

        propertyBlock.SetFloat("_OffsetX", SetRandomUV());
        propertyBlock.SetFloat("_OffsetY", SetRandomUV());
        
        renderer.SetPropertyBlock(propertyBlock);
    }

    float SetRandomUV()
    {
        return Mathf.Round(Random.Range(StaticProperties.minOffset, StaticProperties.maxOffset) *100)/100;
    }

}
