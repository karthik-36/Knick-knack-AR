using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string sceneName){
        Debug.Log("scene is hit  " + sceneName);
       // Application.LoadLevel(sceneName);

       SceneManager.LoadScene(sceneName);
    }
}
