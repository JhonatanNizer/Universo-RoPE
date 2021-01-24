using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entregarlixo : MonoBehaviour {
    #region Variáveis
    public lixosnocenario totaldelixo;
    public GameObject portal;
    public TExtControl texto;
    public Animator movimento;
    public GameObject bateria;
    public AudioSource entregaLixo;
    #endregion

    public void OnTriggerEnter(Collider colisor) {
        if (colisor.tag == ("Player")) {
            if (totaldelixo.totalAcumulado > 0) {
                bateria.SetActive(true);
                totaldelixo.totalAcumulado = 0;
                entregaLixo.Play();
            }
            if (totaldelixo.total == 0) {
                portal.SetActive(true);
                movimento.SetInteger("movimento", 0);
                texto.num_texto = texto.num_texto + 1;
                entregaLixo.Play();
            }
        }
    }

}
