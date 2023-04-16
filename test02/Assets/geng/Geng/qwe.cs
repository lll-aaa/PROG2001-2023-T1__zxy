using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class qwe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Quit()
    {
      Debug.Log("quit");
      Application.Quit();
    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene() . buildIndex + 1);
    }
     public void before()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene() . buildIndex - 1);
    }

}
