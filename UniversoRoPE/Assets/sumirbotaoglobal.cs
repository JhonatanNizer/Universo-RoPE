using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumirbotaoglobal : MonoBehaviour
{

    public selecionar_fase_mundo mundo1;
    public selecionar_fase_mundo mundo2;
    public selecionar_fase_mundo mundo3;
    public toquenatelapariniciar inicial;
    public GameObject botaoGlobal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mundo1.entrou==false &&mundo2.entrou==false&&mundo3.entrou==false && inicial.InicioJogo==false)
        {
            botaoGlobal.SetActive(true);
        }
        else
            botaoGlobal.SetActive(false);


    }
}
