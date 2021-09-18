using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform player2;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform respawnPoint2;

    void OnTriggerEnter(Collider other){

        Debug.Log(other.gameObject.name);

        if(other.gameObject.name == "boat1"){
              player.transform.position = respawnPoint2.transform.position;
        }else{
              player2.transform.position = respawnPoint.transform.position;
        }


    }


    void OnTriggerStay(Collider other){

        Debug.Log(other.gameObject.name);

        if(other.gameObject.name == "boat1"){
              player.transform.position = respawnPoint2.transform.position;
        }else{
              player2.transform.position = respawnPoint.transform.position;
        }


    }


}
