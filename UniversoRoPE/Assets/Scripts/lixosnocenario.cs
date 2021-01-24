using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixosnocenario : MonoBehaviour { 
    public float total;
    public int totalAcumulado;
    public bool possui_aspirador;
    public Animator movimento;
    public TExtControl texto;
    private bool encerrar;

    void Update() {
        if(total==0 &&  encerrar ==false) {
            movimento.SetInteger("movimento", 0);
            //texto.num_texto = texto.num_texto + 1;
            encerrar = true;
        }
    }
}
