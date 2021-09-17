using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    // Start is called before the first frame update

 void OnTriggerEnter(Collider collider)
     { 
         Debug.Log("Collision Detected");
       //  Destroy(gameObject);
 
     }
}
