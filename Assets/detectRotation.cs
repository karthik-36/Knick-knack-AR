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
    bool isReady;
    bool isReadyZ;
    public string city;
    public AudioSource aSource;
    public AudioClip aClip;
    public GameObject weatherTextObject;

    void Start()
    {
        isReady = true;
        if(city == "V"){
             str1 = new string[]{"It is Certain","It is decidedly so","Without a doubt","Yes definitely","You may rely on it","As I see it, yes.","Most likely","Outlook good","Yes","Signs point to yes","Reply hazy, try again","Ask again later","Better not tell you now","Cannot predict now","Concentrate and ask again","Don't count on it","My reply is no","My sources say no","Outlook not so good","Very doubtful"};
        }else{
            str1 = new string[]{"Could you repeat that?","My sources say yes ","nope nope nope <sprite=10>","YeS oF CoUrSe yOu CaN","no <sprite=9>","i don't think so <sprite=9>","You may proceed <sprite=3>","aahh hell naw","if you say so!","Yup Absolutely!"};
        }
        
    }

    // Update is called once per frame
    void Update()
    {
            if((transform.rotation.eulerAngles.x > 80 && transform.rotation.eulerAngles.x < 100 && isReady == true)){
            aSource.PlayOneShot(aClip);
            System.Random random = new System.Random();
            int num = random.Next(0,str1.Length);

            weatherTextObject.GetComponent<TextMeshPro>().text = str1[num];
                isReady = false;
            }


            if((transform.rotation.eulerAngles.z > 80 && transform.rotation.eulerAngles.z < 100 && isReadyZ == true)){
            aSource.PlayOneShot(aClip);
            System.Random random = new System.Random();
            int num = random.Next(0,str1.Length);

            weatherTextObject.GetComponent<TextMeshPro>().text = str1[num];
                isReadyZ = false;
            }


            
            if((transform.rotation.eulerAngles.x < 40 || transform.rotation.eulerAngles.x > 320)){
                isReady = true; 
            }

             if((transform.rotation.eulerAngles.z < 40 || transform.rotation.eulerAngles.z > 320)){
                isReadyZ = true;
            }


    }
}
























