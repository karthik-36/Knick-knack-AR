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

























// using UnityEngine;
// using UnityEngine.Networking;
// using System.Collections;
// using TMPro;
 

// public class WeatherAPIScript : MonoBehaviour
// {
//     public GameObject weatherTextObject;
//     public float lat;
//     public float lon;
//     public string tempType;

   
//         // add your personal API key after APPID= and before &units=
//     string url;

   
//     void Start()
//     {

//     // wait a couple seconds to start and then refresh every 900 seconds
//        url = "http://api.openweathermap.org/data/2.5/weather?lat=" + lat.ToString() + "&lon=" + lon.ToString() + "&APPID=d2e95f8beafef4d5e15f1f216426076c&units=imperial";
//        InvokeRepeating("GetDataFromWeb", 2f, 900f);
//    }

//    void GetDataFromWeb()
//    {

//        StartCoroutine(GetRequest(url));
//    }

//     IEnumerator GetRequest(string uri)
//     {
//         using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
//         {
//             // Request and wait for the desired page.
//             yield return webRequest.SendWebRequest();


//             if (webRequest.isNetworkError)
//             {
//                 Debug.Log(": Error: " + webRequest.error);
//             }
//             else
//             {
//                 // print out the weather data to make sure it makes sense
//                 Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);


//             	// grab the current temperature and simplify it if needed
//             	int startTemp = webRequest.downloadHandler.text.IndexOf("temp",0);
//             	int endTemp = webRequest.downloadHandler.text.IndexOf(",",startTemp);
// 				double tempF = float.Parse(webRequest.downloadHandler.text.Substring(startTemp+6, (endTemp-startTemp-6)));
// 				int easyTempF = Mathf.RoundToInt((float)tempF);
//                 //Debug.Log ("integer temperature is " + easyTempF.ToString());
//                 int startConditions = webRequest.downloadHandler.text.IndexOf("main",0);
//                 int endConditions = webRequest.downloadHandler.text.IndexOf(",",startConditions);
//                 string conditions = webRequest.downloadHandler.text.Substring(startConditions+7, (endConditions-startConditions-8));
//                 //Debug.Log(conditions);

//                 if(tempType == "C"){
//                     float cTemp = ((easyTempF - 30)/2);
//                     weatherTextObject.GetComponent<TextMeshPro>().text = "" + Mathf.RoundToInt((float)cTemp).ToString() + "°C\n" + conditions;
//                 }else{
//                     weatherTextObject.GetComponent<TextMeshPro>().text = "" + easyTempF.ToString() + "°F\n" + conditions;
//                 }
                
//             }
//         }
//     }
// }


