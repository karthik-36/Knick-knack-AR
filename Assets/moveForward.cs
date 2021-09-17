using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    // Update is called once per frame
    public float speed;
    void Update()
    {
       //Vector3 moveDirection = new Vector3(0.0f , 0.0f, speed);
      // transform.position=new Vector3(3 * time.deltatime , 0, 0);
      // transform.position += moveDirection; 
      transform.Translate( 0, 0, speed * Time.deltaTime);
    }
}
