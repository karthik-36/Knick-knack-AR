using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;
 

public class WeatherAPIScript : MonoBehaviour
{
    public GameObject weatherTextObject;
    public float lat;
    public float lon;
    public string tempType;
    int count;

   
        // add your personal API key after APPID= and before &units=
    string url;

   
    void Start()
    {
       count = 0;
    // wait a couple seconds to start and then refresh every 10 seconds
       url = "http://api.openweathermap.org/data/2.5/weather?lat=" + lat.ToString() + "&lon=" + lon.ToString() + "&APPID=d2e95f8beafef4d5e15f1f216426076c&units=imperial";
       InvokeRepeating("GetDataFromWeb", 2f, 15f);
   }

   void GetDataFromWeb()
   {

       StartCoroutine(GetRequest(url));
   }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();


            if (webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the weather data to make sure it makes sense
                Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

                count = count + 1;

            	// grab the current temperature and simplify it if needed
            	int startTemp = webRequest.downloadHandler.text.IndexOf("temp",0);
            	int endTemp = webRequest.downloadHandler.text.IndexOf(",",startTemp);
				double tempF = float.Parse(webRequest.downloadHandler.text.Substring(startTemp+6, (endTemp-startTemp-6)));
				int easyTempF = Mathf.RoundToInt((float)tempF);
                //Debug.Log ("integer temperature is " + easyTempF.ToString());
                int startConditions = webRequest.downloadHandler.text.IndexOf("main",0);
                int endConditions = webRequest.downloadHandler.text.IndexOf(",",startConditions);
                string conditions = webRequest.downloadHandler.text.Substring(startConditions+7, (endConditions-startConditions-8));
                //Debug.Log(conditions);

                if(tempType == "C"){
                    float cTemp = ((easyTempF - 30)/2);
                    weatherTextObject.GetComponent<TextMeshPro>().text = "" + Mathf.RoundToInt((float)cTemp).ToString() + "°C\n" + conditions+ " count : " + count;
                }else{
                    weatherTextObject.GetComponent<TextMeshPro>().text = "" + easyTempF.ToString() + "°F\n" + conditions + " count : " + count;
                }
                
            }
        }
    }
}

