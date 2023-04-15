using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public GameObject FinishCanvas;
    public TMP_Text ui0;

    public GameObject TheScore;
    public TMP_Text ui;
    public int score = 0;

    public bool ifFly = false;

    public AudioSource audio;
    public AudioSource audio1;
    public AudioSource audio2;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Coin")){
            audio.Play();
            if(ifFly)
            {
                if(score > 0)
                {
                    score = score * -1;
                }
                score--;
                ui.text = "SCORE: " + score;
                Destroy(other.gameObject);
            }else{
                score++;
                ui.text = "SCORE: " + score;
                Destroy(other.gameObject);
            }
        }
        if(other.tag.Equals("Finish")){
            Destroy(other.gameObject);
            audio2.Play();
            ui0.text = "SCORE: " + score;
            FinishC();
        }
        if(other.tag.Equals("FlayBall")){
            audio1.Play();
            ifFly = true;
            if(score > 0)
            {
                score = score * -1;
                ui.text = "SCORE: " + score;
            }
        }
    }

    public enum UIStatus
    {
        FinishC,
        Score
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
        FinishCanvas.SetActive(uistatus==UIStatus.FinishC);
        TheScore.SetActive(uistatus==UIStatus.Score);
    }
    public void FinishC()
    {
        Status = UIStatus.FinishC;
    }
    public void Score()
    {
        Status = UIStatus.Score;
    }
}
