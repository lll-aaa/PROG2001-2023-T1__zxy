using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AllSettings : MonoBehaviour
{
    public GameObject TheScore;

    public GameObject Setting;
    public GameObject StopMenu;
    public GameObject HelpBoard;
    public GameObject MusicSet;

    public GameObject Guides;
    public GameObject Tips;

    public TMP_Text ui;

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
        Guide,
        Tip
    }
    public enum UIStatus1
    {
        Set,
        Stop,
        Help,
        Music
    }

    private UIStatus uistatus;
    private UIStatus1 uistatus1;

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
    private UIStatus1 Status1
    {
        get
        {
            return uistatus1;
        }
        set
        {
            uistatus1 = value;
            UpdateUI1();
        }
    }

    public void UpdateUI()
    {
        Guides.SetActive(uistatus == UIStatus.Guide);
        Tips.SetActive(uistatus == UIStatus.Tip);
    }
    public void UpdateUI1()
    {
        Setting.SetActive(uistatus1 == UIStatus1.Set);
        StopMenu.SetActive(uistatus1 == UIStatus1.Stop);
        HelpBoard.SetActive(uistatus1 == UIStatus1.Help);
        MusicSet.SetActive(uistatus1 == UIStatus1.Music);
    }

    public void Guide()
    {
        Status = UIStatus.Guide;
    }
    public void Tip()
    {
        Status = UIStatus.Tip;
    }

    public void Set()
    {
        Status1 = UIStatus1.Set;
    }
    public void Stop()
    {
        Status1 = UIStatus1.Stop;
    }
    public void Help()
    {
        Status1 = UIStatus1.Help;
    }
    public void Music()
    {
        Status1 = UIStatus1.Music;
    }
}
