using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using Unity.Collections;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaneManager : MonoBehaviour
{
    ARRaycastManager _RaycastManager;
    ARPlaneManager _PlaneManager;
    
    static ARPlane chosenPlane;
    static List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    public GameObject startButton;

    int flag = 0;
    void Awake()
    {
        _RaycastManager = GetComponent<ARRaycastManager>();
        _PlaneManager = GetComponent<ARPlaneManager>();
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0 && flag == 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended && Input.touchCount == 1)
            {
                if(_RaycastManager.Raycast(touch.position, raycastHits, TrackableType.PlaneWithinPolygon))
                {
                    chosenPlane = _PlaneManager.GetPlane(raycastHits[0].trackableId);

                    foreach (var plane in _PlaneManager.trackables)
                    {
                        plane.gameObject.SetActive(false);
                    }
                    startButton.SetActive(true);
                    flag = 1;
                }
            }
        }
    }
}
    