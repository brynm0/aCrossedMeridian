using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;


public class BlurController : MonoBehaviour {
    // Use this for initialization

    void Start () {
        var blur = GetComponent<BlurOptimized>();
        blur.enabled = false;
    }

    // Update is called once per frame
    void Update () {
        var blur = GetComponent<BlurOptimized>();
        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 1.0f)
            {
                blur.enabled = true;
            }
            else
            {
                blur.enabled = false;
            }
           
        }

    }
}
