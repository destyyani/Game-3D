using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public int skor = 0;
    public int nilai_menang = 5;
    public Canvas CanvasYouWin;
    public Canvas CanvasKalah;

    // Audio
    public AudioSource BGmusik, youwinMusik; // alternatif buat variabel
    public AudioSource MusikKalah;

    // waktu bermain
    public float StartTime;
    public Text TeksTimer;

    // Start is called before the first frame update
    void Start()
    {
        CanvasYouWin.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (skor >= nilai_menang)
        {
            CanvasYouWin.GetComponent<Canvas>().enabled = true;

            if(BGmusik.isPlaying ) { BGmusik.Stop(); }
            if(!youwinMusik.isPlaying) { youwinMusik.Play(); }
            // tanda ! menunjukan logika Not / lawan dari kondisi isplaying
        }
        StartTime = StartTime - Time.deltaTime;
        TeksTimer.text = StartTime.ToString("0");
        if (skor < nilai_menang && StartTime <= 0.0)
        {
            CanvasKalah.GetComponent<Canvas>().enabled = true;
            if (BGmusik.isPlaying) { BGmusik.Stop(); }
            if (!MusikKalah.isPlaying) { MusikKalah.Play(); }
        }
    }
}
