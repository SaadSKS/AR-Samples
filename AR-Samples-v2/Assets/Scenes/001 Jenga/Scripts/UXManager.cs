using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UXManager : MonoBehaviour
{
    public GameObject ARSessionOrigin;

    public Slider mainSlider;


    public void ValueChangeCheck2()
    {
        //update ar scale here
        ARSessionOrigin.transform.localScale = new Vector3(mainSlider.value, mainSlider.value, mainSlider.value);
    }
}
