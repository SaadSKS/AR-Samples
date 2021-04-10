using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockVariation : MonoBehaviour
{
    public Color blockColor;
    public float tileX;
    public float tileY;

    MaterialPropertyBlock _propertyblock;

    Renderer ren;
    Material blockMat;

    private void Awake()
    {
        if (_propertyblock == null)
            _propertyblock = new MaterialPropertyBlock();

        ren = GetComponentInChildren<Renderer>();
        _propertyblock.SetColor("_Color", blockColor);
        ren.SetPropertyBlock(_propertyblock);

    }

}
