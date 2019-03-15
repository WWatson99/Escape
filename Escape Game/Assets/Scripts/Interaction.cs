﻿using UnityEngine;
using System.Collections;


public class Interaction : MonoBehaviour
{

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
        {
            if (hit.collider.tag.Equals("YourObjectTagHere"))
            {
                Debug.Log("Interact");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.SendMessageUpwards("YourScriptFunctionHere");
                }
            }
        }

    }
}