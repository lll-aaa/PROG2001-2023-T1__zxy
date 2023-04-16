using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_zxy : MonoBehaviour
{
    public Text text;
    public int score = 0;
    public GameObject zxy_menu;
    public AudioSource bird; 
   



    // Start is called before the first frame update
    void Start()
    {
      
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("firend"))
        {
            bird.Play();
            score++;
            text.text = "x" + score;
            Destroy(other.gameObject);
        }
        if (score >= 5)
        {
           zxy_menu.SetActive(true);
           Time.timeScale = 0;
        }
    }
}

