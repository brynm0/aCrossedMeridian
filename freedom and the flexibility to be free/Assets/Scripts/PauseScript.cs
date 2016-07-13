using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
    public GameObject PauseMenu;
    private bool isPaused = false;
    void Start()
    {
        PauseMenu.SetActive(isPaused);

    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 1.0F)
            {
                Cursor.visible = true;
                Time.timeScale = 0.0f;
                isPaused = true;
                PauseMenu.SetActive(isPaused);
                
            }
            else
            {
                Cursor.visible = true;
                Time.timeScale = 1.0F;
                isPaused = false;
                PauseMenu.SetActive(isPaused);

            }
        }
    }
}