using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bateria_control : MonoBehaviour {
    #region Variaveis
    public int energia_total;
    public GameObject[] barra;
    public GameObject findejogo;
    public Image[] cor_;

    public GameObject scriptUi;
    public UiControladora uiControladora;

    public AudioSource audioPrincipal;
    public AudioSource gameOver;
    #endregion

    void Start() {
        scriptUi = GameObject.FindWithTag("UiControladora");
        uiControladora = scriptUi.GetComponent<UiControladora>();
    }
    void Update() {
        UpdateEnergia();
        UpdateCorEnergia();
        if (energia_total == 0 && uiControladora.Mover == false) {
            audioPrincipal.Stop();
            gameOver.Play();
            findejogo.SetActive(true);
            energia_total = -1;
        }
        #region old
        /*
        if (energia_total == 10) {
            barra[0].SetActive(true);
            barra[1].SetActive(true);
            barra[2].SetActive(true);
            barra[3].SetActive(true);
            barra[4].SetActive(true);
            barra[5].SetActive(true);
            barra[6].SetActive(true);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);

            cor_[0].color = new Color(0, 255, 0, 255);
            cor_[1].color = new Color(0, 255, 0, 255);
            cor_[2].color = new Color(0, 255, 0, 255);
            cor_[3].color = new Color(0, 255, 0, 255);
        }

        if (energia_total == 9) {
            barra[0].SetActive(false);
            barra[1].SetActive(true);
            barra[2].SetActive(true);
            barra[3].SetActive(true);
            barra[4].SetActive(true);
            barra[5].SetActive(true);
            barra[6].SetActive(true);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);
        }

        if (energia_total == 8) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(true);
            barra[3].SetActive(true);
            barra[4].SetActive(true);
            barra[5].SetActive(true);
            barra[6].SetActive(true);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);
        }

        if (energia_total == 7) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(true);
            barra[4].SetActive(true);
            barra[5].SetActive(true);
            barra[6].SetActive(true);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);
        }

        if (energia_total == 6) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(false);
            barra[4].SetActive(true);
            barra[5].SetActive(true);
            barra[6].SetActive(true);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);
        }

        if (energia_total == 5) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(false);
            barra[4].SetActive(false);
            barra[5].SetActive(true);
            barra[6].SetActive(true);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);
        }

        if (energia_total == 4) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(false);
            barra[4].SetActive(false);
            barra[5].SetActive(false);
            barra[6].SetActive(true);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);

            cor_[0].color = new Color(255, 1, 0, 255);
            cor_[1].color = new Color(255, 1, 0, 255);
            cor_[2].color = new Color(255, 1, 0, 255);
            cor_[3].color = new Color(255, 1, 0, 255);
        }

        if (energia_total == 3) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(false);
            barra[4].SetActive(false);
            barra[5].SetActive(false);
            barra[6].SetActive(false);
            barra[7].SetActive(true);
            barra[8].SetActive(true);
            barra[9].SetActive(true);
            cor_[1].color = new Color(255, 0.8f, 0, 255);
            cor_[2].color = new Color(255, 0.8f, 0, 255);
            cor_[3].color = new Color(255, 0.8f, 0, 255);

        }

        if (energia_total == 2) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(false);
            barra[4].SetActive(false);
            barra[5].SetActive(false);
            barra[6].SetActive(false);
            barra[7].SetActive(false);
            barra[8].SetActive(true);
            barra[9].SetActive(true);
            cor_[2].color = new Vector4(100, 0.5f, 0, 255);
            cor_[3].color = new Color(100, 0.5f, 0, 255);
        }

        if (energia_total == 1) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(false);
            barra[4].SetActive(false);
            barra[5].SetActive(false);
            barra[6].SetActive(false);
            barra[7].SetActive(false);
            barra[8].SetActive(false);
            barra[9].SetActive(true);
            cor_[3].color = new Color(255, 0, 0, 255);
        }

        if (energia_total == 0) {
            barra[0].SetActive(false);
            barra[1].SetActive(false);
            barra[2].SetActive(false);
            barra[3].SetActive(false);
            barra[4].SetActive(false);
            barra[5].SetActive(false);
            barra[6].SetActive(false);
            barra[7].SetActive(false);
            barra[8].SetActive(false);
            barra[9].SetActive(false);
        }
        */
        #endregion
    }

    public void usarbateria() {
        if (uiControladora.ListaComandos.Count > 0 && uiControladora.EstaMovendo == false) {
            energia_total--;
        }
    }

    private void UpdateEnergia() {
        for (int i = 0; i <= 9; i++) {
            if (9 - i < energia_total) {
                barra[i].SetActive(true);
            } else {
                barra[i].SetActive(false);
            }
        }

    }
    private void UpdateCorEnergia() {
        if (energia_total == 4) {
            cor_[0].color= new Color(255, 1, 0, 255);
            cor_[1].color = new Color(255, 1, 0, 255);
            cor_[2].color = new Color(255, 1, 0, 255);
            cor_[3].color = new Color(255, 1, 0, 255);
        } else if (energia_total == 3) {
            cor_[1].color = new Color(255, 0.8f, 0, 255);
            cor_[2].color = new Color(255, 0.8f, 0, 255);
            cor_[3].color = new Color(255, 0.8f, 0, 255);
        } else if (energia_total == 2) {
            cor_[2].color = new Vector4(100, 0.5f, 0, 255);
            cor_[3].color = new Color(100, 0.5f, 0, 255);
        } else if (energia_total == 1) {
            cor_[3].color = new Color(255, 0, 0, 255);
        } else{
            cor_[0].color = new Color(0, 255, 0, 255);
            cor_[1].color = new Color(0, 255, 0, 255);
            cor_[2].color = new Color(0, 255, 0, 255);
            cor_[3].color = new Color(0, 255, 0, 255);
        }
    }

}