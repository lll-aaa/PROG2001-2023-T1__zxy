using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fff: MonoBehaviour
{
    public GameObject aa;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void open_pause()
    {
        Time.timeScale = 0;
        aa.SetActive(true);
    }
      public void close_pause()
    {
        Time.timeScale =1;
        aa.SetActive(false);
    }
}