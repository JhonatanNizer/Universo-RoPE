using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class girarengrenagens : MonoBehaviour {
    #region Vari�veis
    public UiControladora UiControladora;
    public Animator anima��o1;
    public Animator anima��o2;
    public Animator anima��o3;
    public Animator anima��o4;
    public GameObject a�oes;
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
            anima��o1.SetBool("andando", true);
            anima��o2.SetBool("andando", true);
            anima��o3.SetBool("andando", true);
            anima��o4.SetBool("andando", true);
        } else {
            anima��o1.SetBool("andando", false);
            anima��o2.SetBool("andando", false);
            anima��o3.SetBool("andando", false);
            anima��o4.SetBool("andando", false);
        }
    }
    private void UpdateAcoes() {
        if (UiControladora.Mover == true) {
            if (UiControladora.comandosExecutados == 0) {
                a�oes.transform.localPosition = new Vector3(0, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 1) {
                a�oes.transform.localPosition = new Vector3(-30, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 2) {
                a�oes.transform.localPosition = new Vector3(-60, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 3) {
                a�oes.transform.localPosition = new Vector3(-90, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 4) {
                a�oes.transform.localPosition = new Vector3(-120, 1.7f, 0);
            }
            if (UiControladora.comandosExecutados == 5) {
                a�oes.transform.localPosition = new Vector3(-150, 1.7f, 0);
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
            a�oes.transform.localPosition = new Vector3(0, 1.7f, 0);
            tempo = 0;
        }
    }
}
