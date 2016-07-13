using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TitleOneTrigger : MonoBehaviour 
{
    public Image MainTitleImage;
    public Text MainTitleText;

    // Use this for initialization
    void Start()
    {
        MainTitleImage.GetComponent<Image>().CrossFadeAlpha(0.0f, 0.0f, false);
        MainTitleText.GetComponent<Text>().CrossFadeAlpha(0.0f, 0.0f, false);

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider obj)
    { // turn message on when player is inside the trigger if (obj.tag == "Player") guiOn = true; }
        if (obj.tag == "Player")
        { 
            Debug.Log("Player has exited MainTitleTrigger");
            MainTitleImage.GetComponent<Image>().CrossFadeAlpha(0.75f,2.0f,false);
            MainTitleText.GetComponent<Text>().CrossFadeAlpha(0.75f, 2.0f, false);


            //MainTitle.GetComponent<CanvasRenderer>().CrossFadeAlpha(0.75f, 1.0f, false);
        }
    }
    void OnTriggerExit(Collider obj)
    { // turn message on when player is inside the trigger if (obj.tag == "Player") guiOn = true; }
        if (obj.tag == "Player")
        {
            Debug.Log("Player has entered MainTitleTrigger");
            MainTitleImage.GetComponent<Image>().CrossFadeAlpha(0.0f, 2.0f, false);
            MainTitleText.GetComponent<Text>().CrossFadeAlpha(0.0f, 2.0f, false);


            //MainTitle.GetComponent<CanvasRenderer>().CrossFadeAlpha(0.75f, 1.0f, false);
        }
    }

}
