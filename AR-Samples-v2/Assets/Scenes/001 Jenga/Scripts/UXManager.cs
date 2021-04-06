using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UXManager : MonoBehaviour
{
    public GameObject ARSessionOrigin;

    public Slider mainSlider;

    public void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        //mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    /*public void ValueChangeCheck()
    {
        Debug.Log("1");
        //update ar scale here
    }*/


    public void ValueChangeCheck2()
    {
        Debug.Log(mainSlider.value);
        //update ar scale here
        ARSessionOrigin.transform.localScale = new Vector3(mainSlider.value, mainSlider.value, mainSlider.value);
    }
}
