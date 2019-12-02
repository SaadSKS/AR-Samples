using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class oneFingerDrag : MonoBehaviour
{
    public LeanTweenType easeType;
    public float spd=1f;

    void Start()
    {
        LeanTween.moveY(gameObject.GetComponent<RectTransform>(), 200f, spd).setLoopPingPong().setEase(easeType);
    }
}
