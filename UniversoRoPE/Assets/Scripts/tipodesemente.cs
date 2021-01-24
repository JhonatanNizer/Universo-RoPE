using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tipodesemente : MonoBehaviour
{
    public int semente;
    public string[] cor;
    public bool coletou;
    public tipodesemente outra;
    public GameObject outra_oj;
    public GameObject sementeativa;

    public AudioSource itemPick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coletou)
        {
            sementeativa.SetActive(true);
        }
        else
            sementeativa.SetActive(false);

    }
    void OnTriggerEnter(Collider colisor)
    {
        if (colisor.gameObject.tag == ("Player"))
        {
            itemPick.Play();
            coletou = true;
            outra.coletou = false;
            sementeativa.SetActive(true);
            this.gameObject.SetActive(false);
            outra_oj.SetActive(true);
            

        }


    }
}
