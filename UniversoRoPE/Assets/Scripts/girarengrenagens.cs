using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class girarengrenagens : MonoBehaviour {
    #region Variáveis
    public UiControladora UiControladora;
    public Animator animação1;
    public Animator animação2;
    public Animator animação3;
    public Animator animação4;
    public GameObject açoes;
    public float tempo;
    public bool finalizou;
    public bool iniciarfinal;
    #endregion

    void Update() {
        UpdateEngrenagens();
        //UpdateAcoes();
    }

    private void UpdateEngrenagens() {
        if (UiControladora.Mover == true) {
            animação1.SetBool("andando", true);
            animação2.SetBool("andando", true);
            animação3.SetBool("andando", true);
            animação4.SetBool("andando", true);
        } else {
            animação1.SetBool("andando", false);
            animação2.SetBool("andando", false);
            animação3.SetBool("andando", false);
            animação4.SetBool("andando", false);
        }
    }
    private void UpdateAcoes() {
        if (UiControladora.Mover == true) {
            if (UiControladora.comandosExecutados == 0) {
                açoes.transform.localPosition = new Vector3(0, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 1) {
                açoes.transform.localPosition = new Vector3(-30, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 2) {
                açoes.transform.localPosition = new Vector3(-60, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 3) {
                açoes.transform.localPosition = new Vector3(-90, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 4) {
                açoes.transform.localPosition = new Vector3(-120, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 5) {
                açoes.transform.localPosition = new Vector3(-150, 1.7f, 0);
            }
        }
        if (UiControladora.comandosExecutados == 6)
            iniciarfinal = true;
        if (iniciarfinal == true)
            tempo = tempo + Time.deltaTime;
        if (tempo > 1)
            finalizou = true;
        if (tempo > 2) {
            iniciarfinal = false;
            finalizou = false;
            açoes.transform.localPosition = new Vector3(0, 1.7f, 0);
            tempo = 0;
        }
    }
}
