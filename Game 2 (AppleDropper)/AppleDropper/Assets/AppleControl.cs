using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine;

public class AppleControl : MonoBehaviour
{
    public float speed;
    public Transform targetLocation;
    public Transform startLocation;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startLocation.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetLocation.position, speed * Time.deltaTime);
    }
}