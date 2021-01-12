﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;


    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 10.0f;
    private float CurrentX = 0.0f;
    private float CurrentY = 0.0f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 1.0f;

    private void Start ()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update ()
    {
        CurrentX += Input.GetAxis("Mouse X");
        CurrentY += Input.GetAxis("Mouse Y");

        CurrentYv = Mathf.Clamp(CurrentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate ()
    {
        Vector3 dir = new Vector3(0,0,-distance);
        Quaternion rotation = Quaternion.Euler(CurrentY, CurrentX,0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}
