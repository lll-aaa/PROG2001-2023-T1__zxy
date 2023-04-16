using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToGuide()
    {
        SceneManager.LoadScene(2);
    }
    public void Rebirth()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
