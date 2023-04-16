using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour
{
    public GameObject aa;
    public GameObject AAA;
    public GameObject BBB;
    
    
   
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
        BBB.SetActive(true);
    }
    public void open_help()
    {
        Time.timeScale = 0;
        aa.SetActive(false);
        AAA.SetActive(true);
        BBB.SetActive(false);

    }
      public void close_help()
    {
        Time.timeScale =1;
        aa.SetActive(true);
        AAA.SetActive(false);
       
        
    }
     
}
