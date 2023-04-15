using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject helpUI;
    public GameObject settingUI;
    public GameObject soundUI;
    public GameObject playerUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void help_open()
    {
        settingUI.SetActive(false);
        helpUI.SetActive(true);
    }
    public void help_close()
    {
        helpUI.SetActive(false);
        settingUI.SetActive(true);
    }
    public void setting_open()
    {
        playerUI.SetActive(false);
        Time.timeScale = 0;
        settingUI.SetActive(true);
    }
    public void setting_close()
    {
        playerUI.SetActive(true);
        Time.timeScale = 1;
        settingUI.SetActive(false);
    }
    public void sound_open()
    {
        settingUI.SetActive(false);
        soundUI.SetActive(true);
    }
    public void sound_close()
    {
        soundUI.SetActive(false);
        settingUI.SetActive(true);
    }
}
