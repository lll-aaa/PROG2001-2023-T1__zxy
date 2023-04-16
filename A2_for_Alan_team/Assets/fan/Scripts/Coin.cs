using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool rX = false;
    public bool rY = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rX)
        {
            transform.Rotate(3,0,0);
        }else if(rY){
            transform.Rotate(0,3,0);
        }else{
            transform.Rotate(0,0,3);
        }

    }
}
