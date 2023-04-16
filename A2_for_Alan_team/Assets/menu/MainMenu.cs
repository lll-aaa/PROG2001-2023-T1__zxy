using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject TwoC;
    public GameObject FourC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum UIStatus
    {
        Two,
        Four
    }
    private UIStatus uistatus;
    private UIStatus Status
    {
        get
        {
            return uistatus;
        }
        set
        {
            uistatus = value;
            UpdateUI();
        }
    }
    public void UpdateUI()
    {
        TwoC.SetActive(uistatus == UIStatus.Two);
        FourC.SetActive(uistatus == UIStatus.Four);
    }

    public void Two()
    {
        Status = UIStatus.Two;
    }
    public void Four()
    {
        Status = UIStatus.Four;
    }
}
