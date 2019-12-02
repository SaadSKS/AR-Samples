using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class Gestures : MonoBehaviour
{
    public LeanTweenType easeType;
    public float spd = 1f;

    GameObject Drag1F; //one finger drag image
    GameObject hint1F; //hint text for one finger drag

    void OnEnable()
    {
        hint1F = transform.Find("oneFingerHint").gameObject;
        hint1F.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);     //CHANGE TO ALPHA BLEND
        LeanTween.scale(hint1F.GetComponent<RectTransform>(), new Vector3(1, 1, 1), 0.5f);
        //LeanTween.scale
        Drag1F = transform.Find("oneFingerDrag").gameObject;
        LeanTween.moveY(Drag1F.GetComponent<RectTransform>(), 200f, spd).setLoopPingPong().setEase(easeType).setDelay(2f);
    }

    void OnDisable()
    {
        //stop motion
    }


}
