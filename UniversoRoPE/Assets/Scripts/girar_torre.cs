using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class girar_torre : MonoBehaviour
{
    public GameObject torre;
    public GameObject desativar;
    public GameObject ativar;
    public bool ativado;
    public float tempo;
    public Quaternion rotaçãodesejada;
    public GameObject[] apagar;
    public GameObject[] ligar;
    public AudioSource buttonClick2;
    public controladorTextofese3 locais;
    public Animator movimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ativado == true)
        {
            tempo = tempo + Time.deltaTime / 5;
            torre.transform.rotation = Quaternion.Lerp(torre.transform.rotation, rotaçãodesejada, tempo*2);
           
            for (int i = 0; i <= apagar.Length; i++)
            {
                if (i < apagar.Length)
                {
                    apagar[i].SetActive(false);
                   
                }
                else
                    break;
            }
                for (int t = 0; t <= ligar.Length; t++)
                {
                    if (t < ligar.Length)
                        ligar[t].SetActive(true);
                else
                    break;
            }
            
        }
        if (tempo > 1)
        {
            ativado = false;
            desativar.SetActive(false);
        }

    }
    public void OnTriggerEnter(Collider colisor)
    {
        if (colisor.tag == ("Player"))
        {
            ativado = true;
            ativar.SetActive(true);
            buttonClick2.Play();
            locais.num += 1;
            movimento.SetInteger("movimento", 0);

        }
    }
}
    