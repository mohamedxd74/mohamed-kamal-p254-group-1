using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Transform CamTransform; // Camera transform params
    public float shakeTime; // how long we want to shacke our camera
    public float shakeRange; // how far we want to move our camera
    Vector3 originalPos; // restore original cam pos

    // Start is called before the first frame update
    void Start()
    {
        CamTransform = Camera.main.transform;
        originalPos = CamTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShakeCamera()); // StartCoroutine("ShakeCamera")
        }
    }

    IEnumerator ShakeCamera()
    {
        float elapsedTime = 0;
        while (elapsedTime < shakeTime)
        {
            CamTransform.position = Random.insideUnitSphere * shakeRange;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        CamTransform.position = originalPos;
    }
}