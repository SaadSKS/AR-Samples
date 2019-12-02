using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarveTool : MonoBehaviour
{
    public GameObject vase;

    GameObject indicator;
    MeshRenderer mr;
    enum Mode { Instructions, View, setPosition, Pattern1, Pattern2, Pattern3, Pattern4, Idle, Paint};
    Mode mode;

    bool indicatorReset;

    void Start()
    {
        mode = Mode.Instructions;
        indicator = vase.transform.Find("VaseIndicator").gameObject;
        indicator.SetActive(false);
        mr = vase.GetComponent<MeshRenderer>();
        
        //reset flags
        indicatorReset = true;

    }

    // Update is called once per frame
    void Update()
    {
        switch (mode)
        {
            case (Mode.Instructions):
                {
                    //Explain how to search for planes (LIVE). Guidelines already explained in MainMenu
                    break;
                }
            case (Mode.setPosition):
                {
                    setPosition();
                    break;
                }
            case (Mode.Pattern1):
                {
                    //Place Indicator

                    break;
                }
            case (Mode.Pattern2):
                {

                    break;
                }
            case (Mode.Paint):
                {

                    break;
                }


        }

    }

    void IndicatorGuide()
    {
        if (indicatorReset)
        {
            indicator.SetActive(true); //indicator is made visible
            indicator.transform.position = new Vector3(0, 2, 0); //Reset transform to its original position
            indicatorReset = false;
        }
        //Display Drag Hint on screen UI
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                //Input.touches[0].position

            }
        }
    }

    private void setPosition()
    {
        //Place Vase on AR Planes
    }


    /*
    void NewPattern()
    {
        if (mode == Mode.setPosition) //Adjust Height of Pattern
        {
            if (Input.touchCount > 0)
            {
                if (Input.touches[0].phase == TouchPhase.Began)
                {
                    //one finger pressed
                    //startPos touchVert pos
                }
            }
        }
    }
    */
    //setup placeVase, RepositionVase, 


}
