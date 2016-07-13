using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
    public AudioSource highHigh;
    public AudioSource highLow;
    public AudioSource lowHigh;
    public AudioSource lowLow;
    float pitchLowLimit = 0.99f;
    float pitchHighLimit = 1.01f;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Fire1") && !Input.GetKey(KeyCode.LeftShift))
        {
            highHigh.Play();
            highHigh.pitch = Random.Range(pitchLowLimit, pitchHighLimit);

        }
        if (Input.GetButtonDown("Fire2") && !Input.GetKey(KeyCode.LeftShift))
        {
            highLow.Play();
            highLow.pitch = Random.Range(pitchLowLimit, pitchHighLimit);

        }
        if (Input.GetButtonDown("Fire1") && Input.GetKey(KeyCode.LeftShift))
        {
            lowHigh.Play();
            lowHigh.pitch = Random.Range(pitchLowLimit, pitchHighLimit);

        }

        if (Input.GetButtonDown("Fire2") && Input.GetKey(KeyCode.LeftShift))
        {
            lowLow.Play();
            lowLow.pitch = Random.Range(pitchLowLimit, pitchHighLimit);

        }

    }
}
