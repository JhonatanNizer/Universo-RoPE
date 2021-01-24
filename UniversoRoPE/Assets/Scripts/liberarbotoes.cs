using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liberarbotoes : MonoBehaviour
{
    public GameObject botaoação;
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
            botaoação.SetActive(false);
        else
            botaoação.SetActive(true);
         if (uicontroladora.ListaComandos.Count == 6)
            todosbotoes.SetActive(true);
        else
            todosbotoes.SetActive(false);


    }
}
