using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public static bool GameisPause = false;
    public GameObject PausemenuI;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPause)
            {
                Resume();
            }else
            {
                pause();
            }
        }
        
    }
    void Resume()
    {
        PausemenuI.SetActive(false);
        Time.timeScale = 1f;
        GameisPause = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void pause()
    {
        PausemenuI.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0f;
        GameisPause = true;
    }
}
