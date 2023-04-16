using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
