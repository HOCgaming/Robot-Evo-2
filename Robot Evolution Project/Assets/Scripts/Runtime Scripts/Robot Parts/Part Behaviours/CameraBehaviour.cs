﻿using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour
{
    private PartClass myPartClass;
    private Camera myCamera;

    void Start()
    {
        myPartClass = gameObject.GetComponent<PartClass>();
        myCamera = gameObject.AddComponent<Camera>();
        myCamera.nearClipPlane = 0.1f;
        myCamera.enabled = false;

    }

    void Update()
    {

        /*
        if(myPartClass.onAttach) {
            myCamera.enabled = true;
        }
        if(myPartClass.onDetach) {
            myCamera.enabled = false;
        }
        */

        if (myPartClass.getAttachmentStatus()) {

            if (Input.GetKeyDown(KeyCode.C)) { }
            if (Input.GetKeyDown(KeyCode.V)) { }
        }
            
    }

    /* GET AND SET
    STARTING TO MAKE SENSE,
    NOT SO FUNNY ANY MORE */

    public Camera getMyCamera() { return myCamera; }
}