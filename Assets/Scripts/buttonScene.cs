using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class buttonScene : MonoBehaviour
{
    public GameObject pauseUI;
    public AudioMixer audioMixer;
    public Slider volSlider;

    // Start is called before the first frame update
    void Start()
    {
        audioMixer.GetFloat("volume", out float cv);

        volSlider.value = cv;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(string scene)
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(scene);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 1;
    }

    public void PauseLevel()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseUI.SetActive(true);
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pauseUI.SetActive(false);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("exit button pressed");
    }
}
