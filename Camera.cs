using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speedP = 2.0f;
    public float speedQ = 2.0f;

    private float startX = 0.0f;
    private float startY = 0.0f;

    void Update()
    {
        startX += speedP * Input.GetAxis("Mouse X");
        startY += speedQ * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(startY, startX, 0.0f);
    }
}
