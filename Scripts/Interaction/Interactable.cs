using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string id;
    public abstract void Interact();
    //Don't know how to use that ^^^^
    //attempting to follow a vid tutorial, not sure what certain things mean...
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * raycastDistance);

        RaycastHit hitInfo = id;
        if (Physics.Raycast(ray, out hitInfo, raycastDistance, layerMask);){
            if(hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Debug.Log(hitInfo.collider.GetComponent<Interactable>().promptMessage);
            }
        }
    }




}
