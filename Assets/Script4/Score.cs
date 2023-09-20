using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject asalscore;
   // public Text TeksSkor; (teks standar)

    //textmeshpro
    public TMP_Text TeksSkorIndah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // TeksSkor.text = "Score :"+asalscore.GetComponent<Game_Manager>().skor.ToString(); (teks standar)
        TeksSkorIndah.text = "Score :" + asalscore.GetComponent<Game_Manager>().skor.ToString();
    }
}
