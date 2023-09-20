using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kendali_Tombol : MonoBehaviour
{
    int atas, bawah, kiri, kanan;
    public GameObject CubeUfo;
    public float kecepatanUfo;
    // Start is called before the first frame update
    void Start()
    {
        //kecepatanUfo = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (atas == 1)
        {
            float gerak = Time.deltaTime * kecepatanUfo;
            CubeUfo.transform.Translate(0, 0, gerak);
        }

        if (bawah == 1)
        {
            float gerak = Time.deltaTime * kecepatanUfo;
            CubeUfo.transform.Translate(0, 0, -gerak);
        }

        if (kanan == 1)
        {
            float gerak = Time.deltaTime * kecepatanUfo;
            CubeUfo.transform.Translate(gerak, 0, 0);
        }
        if (kiri == 1)
        {
            float gerak = Time.deltaTime * kecepatanUfo;
            CubeUfo.transform.Translate(-gerak, 0, 0);
        }
    }

    public void atasditekan() { atas = 1; }
    public void atasdilepas() { atas = 0; }
    public void bawahditekan() { bawah = 1; }
    public void bawahdilepas() { bawah = 0; }
    public void kananditekan() { kanan = 1; }
    public void kanandilepas() { kanan = 0; }
    public void kiriditekan() { kiri = 1; }
    public void kiridilepas() { kiri = 0; }
}
