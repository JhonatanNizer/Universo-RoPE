using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class efeitoraio : MonoBehaviour
{ public float força;
    public float tamanho;
    public float tempomudar;
    public int segmento;
    public distanciadoraio distanciadoraio_;
    public LineRenderer ir_raio;
    private float tempocorrer;
    private float axiturb;
    private float axitama;
    public GameObject luzB;
    // Start is called before the first frame update
    void start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        tamanho = distanciadoraio_.distancia;
        luzB.transform.localPosition = new Vector3(tamanho, 0, 0);
        tempocorrer += Time.deltaTime;
        if(tempocorrer >= tempomudar) { 
            for (int i = 1; i < segmento;i ++){
                axiturb = força * (tamanho / 100);
                axitama = tamanho/segmento;
                ir_raio.SetPosition(i, new Vector3(i * axitama, UnityEngine.Random.Range(-axiturb, axiturb), UnityEngine.Random.Range(-axiturb, axiturb)));
            }
        }
        ir_raio.SetPosition(9, new Vector3(tamanho,0,0));
    }
}
     