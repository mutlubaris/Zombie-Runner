using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 30f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;

    bool aimToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(aimToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        aimToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }

    private void ZoomOut()
    {
        aimToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }
}
