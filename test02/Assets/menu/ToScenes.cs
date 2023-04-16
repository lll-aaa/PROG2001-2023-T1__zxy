using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScenes : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToZ()
    {
        SceneManager.LoadScene(1);
    }
    public void ToG()
    {
        SceneManager.LoadScene(3);
    }
    public void ToF()
    {
        SceneManager.LoadScene(4);
    }
    public void ToL()
    {
        SceneManager.LoadScene(5);
    }
    public void ToCredit()
    {
        SceneManager.LoadScene(6);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void AudioPlay()
    {
        audio.Play();
    }
}
