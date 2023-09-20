using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koin_Skor : MonoBehaviour
{
    public float KecepatanPutar;
    GameObject manajer;

    public AudioSource efeksuara;
    // Start is called before the first frame update
    void Start()
    {
        manajer = GameObject.FindGameObjectWithTag("pemain");
        // bukan FindGameObjects... tanpa s
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, KecepatanPutar);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pemain")
        {
            manajer.GetComponent<Game_Manager>().skor++;
            efeksuara.Play();


            Destroy(this.gameObject); // Menghapus koin
        }
    }
}
