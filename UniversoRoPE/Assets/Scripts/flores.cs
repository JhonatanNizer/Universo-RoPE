using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flores : MonoBehaviour
{
    public GameObject mato;
    public GameObject flor;
    public Vector3 recolhido;
    public Vector3 crecido;
    public bool plantou;
    public bool molhou;
    private float tempo;
    private float tempo2;
    public tipodesemente semente;
    public AudioSource plantaSemente;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plantou==true)
        {
            mato.SetActive(true);
            tempo = tempo + Time.deltaTime;
            mato.transform.localScale = Vector3.Lerp((recolhido),( crecido), tempo);
        }
        if (molhou == true)
        {
            flor.SetActive(true);
            tempo2 = tempo2 + Time.deltaTime;
            flor.transform.localScale = Vector3.Lerp((recolhido), (crecido), tempo2);
        }
    }
    public void OnTriggerEnter(Collider other)
    {if (other.gameObject.tag == ("Player"))
            if (semente.coletou == true)
            {
                plantou = true;
                plantaSemente.Play();
            }
    }
}
