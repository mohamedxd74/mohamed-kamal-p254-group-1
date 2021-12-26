using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed2D;
    public float zoomSpeed3D;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.orthographic)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0) // zoom in
            {
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0) // zoom out
            {
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
            }
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 8, 15); //restrict Size within [1;5]
        }
        else
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0) // zoom in
            {
                Camera.main.fieldOfView -= zoomSpeed3D * Time.deltaTime;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0) // zoom out
            {
                Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
            }
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 40, 80); //restrict Size within [10;50]
        }
    }
}