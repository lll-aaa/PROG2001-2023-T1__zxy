using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpUI : MonoBehaviour
{
    public Slider slider;
    public GameObject targetObject;
    private float y;
    private Vector3 p;
    private Vector3 p_;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = targetObject.transform.position;
        y = pos.y;
    }

    // Update is called once per frame
    void Update()
    { 
           
        
    }

    public void Slid()
    {
        p_ = targetObject.transform.position;
        p_.y=y + slider.value * 50;
        targetObject.transform.position = p_;
        
    }
}


