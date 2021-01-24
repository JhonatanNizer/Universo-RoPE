using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegaraspirador : MonoBehaviour
{ 
    public GameObject coletor;
    public lixosnocenario script;
    public Animator movimento;
    public TExtControl texto;

    public AudioSource itempick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider colisor)
    {
        if (colisor.tag == ("Player"))
        {
            script.possui_aspirador = true;
            coletor.SetActive(true);
            Destroy(this.gameObject);
            movimento.SetInteger("movimento", 0);
            texto.num_texto = texto.num_texto + 1;
            itempick.Play();
        }
    }
}
