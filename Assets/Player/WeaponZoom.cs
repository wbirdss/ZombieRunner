using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 10f;

    bool zoomedInToggle = false;

    private void OnDisable() {
        ZoomOut();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle)
            {
                ZoomOut();
            }
            else
            {
                ZoomIn();
            }
        }
    }

    void ZoomIn()
    {
        Debug.Log("zooming in");
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
    }

    void ZoomOut()
    {
        Debug.Log("zooming out");
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
    }
}
