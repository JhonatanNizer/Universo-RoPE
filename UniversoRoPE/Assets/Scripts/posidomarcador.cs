using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posidomarcador : MonoBehaviour
{
    public UiControladora ui;
    public Transform[] posiçoes;
    public int comando;
    public float tempo;
    public bool proximo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        comando = ui.indexComandoAtual;
        if (ui.Mover==true)
        {
            proximo = true;
        }
        else
            proximo = false;

        if (proximo==true)
        {

            tempo = tempo + Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, posiçoes[comando].position, tempo);
        }
        if(proximo==false)
        {
            tempo = 0;
            transform.position = posiçoes[0].position;
        }
        
        
    }
}
