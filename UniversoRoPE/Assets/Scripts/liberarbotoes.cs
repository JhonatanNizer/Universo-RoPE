using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liberarbotoes : MonoBehaviour
{
    public GameObject botaoa��o;
    public GameObject todosbotoes;
    public UiControladora uicontroladora;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (uicontroladora.ListaComandos.Count == 6)
            botaoa��o.SetActive(false);
        else
            botaoa��o.SetActive(true);
         if (uicontroladora.ListaComandos.Count == 6)
            todosbotoes.SetActive(true);
        else
            todosbotoes.SetActive(false);


    }
}
