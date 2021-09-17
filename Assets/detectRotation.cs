using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class detectRotation : MonoBehaviour
{
    // Start is called before the first frame update

    //public Text changingText;

   // public GameObject changingTextTwo;
    string[] str1;
    float xRotate;
    float followThrough;
    float stepRotation;
    float totalRotation;

    void Start()
    {
        xRotate = transform.localEulerAngles.x;
        followThrough = transform.localEulerAngles.x;
        stepRotation = 0;
        totalRotation = 0;
    
        str1 = new string[]{"It is Certain","It is decidedly so","Without a doubt","Yes definitely","You may rely on it","As I see it, yes.","Most likely","Outlook good","Yes","Signs point to yes","Reply hazy, try again","Ask again later","Better not tell you now","Cannot predict now","Concentrate and ask again","Don't count on it","My reply is no","My sources say no","Outlook not so good","Very doubtful"};
    }

    // Update is called once per frame
    void Update()
    {


        // xRotate = transform.localEulerAngles.x;

        // if((xRotate - followThrough) > 0){
        //     stepRotation = xRotate - followThrough;
        //     followThrough = xRotate;
        // }


        // Debug.Log("totalRotation : " + totalRotation + "       " + " stepRotation : " + stepRotation);
        // totalRotation = totalRotation + stepRotation;
        

        if (transform.rotation.eulerAngles.x == 90)
        {
        // Do something
        
            System.Random random = new System.Random();
            int num = random.Next(0,str1.Length);

            totalRotation = 0;
            Debug.Log(str1[num]);

        }

        // if(totalRotation > 60){

        //     System.Random random = new System.Random();
        //     int num = random.Next(0,str1.Length);

        //     totalRotation = 0;
        //     Debug.Log(str1[num]);
          
        // }

       
        



    }
}
