using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackEvent : MonoBehaviour
{
 private void OnTrackingFound()
     {
        //  Renderer[] rendererComponents = GetComponentsInChildren<Renderer>();
 
        //  // Enable rendering:
        //  foreach (Renderer component in rendererComponents) {
        //      component.enabled = true;
        //  }
 
         Debug.Log("Trackable  found");
         
 }
}
