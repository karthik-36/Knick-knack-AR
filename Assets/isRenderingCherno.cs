using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isRenderingCherno : MonoBehaviour
{

    Renderer rend;
    bool isReady;
    [SerializeField] AudioSource aSource;
    [SerializeField] AudioClip aClip;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        isReady = true;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("rendering " + rend.enabled);   

        if(rend.enabled == true && isReady == true){
           isReady = false;
           aSource.Play(0);

        } 

        if(!rend.enabled){
            aSource.Pause();
            isReady = true;
        }
    }
}
