using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativarmangeira : MonoBehaviour
{
    public flores[] flores;
    public int plantadas;
    public bool[] feito;
    public GameObject efeito;
    public bool molhar;
    public float tempo;
    public TExtControl texto;
    private bool trava;
    public Animator movimento;
    public TExtControl text;
    public AudioSource irrigaSemente;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < flores.Length; i++)
        if(flores[i].plantou==true && feito[i]==false)
        {
            plantadas += 1;
                feito[i] = true;
        }

        if(molhar==true)
        tempo = tempo + Time.deltaTime*1.6f;

        for (int i =0;i<15;i++)
        {
            if(tempo>i)
            flores[i].molhou = true;
        }
        if (plantadas >= flores.Length && trava==false)
        {
            texto.num_texto += 1;
            movimento.SetInteger("movimento", 0);
            trava = true;

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
            if (plantadas >= flores.Length)
            {
                irrigaSemente.Play();
                text.fexar();
                efeito.SetActive(true);
                molhar = true;
            }
    }
}
