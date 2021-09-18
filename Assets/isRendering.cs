using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isRendering : MonoBehaviour
{


    Renderer rend;
    bool isReady;
    [SerializeField] public bool needRespawn;
    [SerializeField] public Transform player;
    [SerializeField] public Transform player2;
    [SerializeField] public Transform respawnPoint;
    [SerializeField] public Transform respawnPoint2;


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
            if(needRespawn){
              player.transform.position = respawnPoint2.transform.position;
              player2.transform.position = respawnPoint.transform.position;
            }
           isReady = false;
           aSource.Play(0);

        } 

        if(!rend.enabled){
            aSource.Pause();
            isReady = true;
        }
    }
}
