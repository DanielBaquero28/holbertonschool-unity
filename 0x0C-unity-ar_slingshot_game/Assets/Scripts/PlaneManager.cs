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
    public GameObject instanceObject { get; private set; }
    public GameObject obstaclePrefab;
    float i = 0.07f;
    float j = -0.07f;
    public int numberTargets = 3;

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
                    Vector3 centerPlane = new Vector3(chosenPlane.center.x, chosenPlane.center.y, chosenPlane.center.z);
                    instanceObject = Instantiate(obstaclePrefab, centerPlane, Quaternion.identity);
                    for (int k = 1; k < numberTargets; k++, i += 0.07f, j -= 0.07f)
                        instanceObject = Instantiate(obstaclePrefab, centerPlane + new Vector3(i, 0, j), Quaternion.identity);
                    foreach (var plane in _PlaneManager.trackables)
                    {
                        if (plane == chosenPlane)
                            continue;
                        plane.gameObject.SetActive(false);
                    }
                    startButton.SetActive(true);
                    flag = 1;
                }
            }
        }
    }
}
    