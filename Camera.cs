using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speedP = 2.0f;
    public float speedQ = 2.0f;

    private float ye = 0.0f;
    private float haw = 0.0f;

    void Update()
    {
        ye += speedP * Input.GetAxis("Mouse X");
        haw += speedQ * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(haw, ye, 0.0f);
    }
}
