using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasEscala : MonoBehaviour { 

    public Canvas canvas;
    public float larguraTela;
    public float scaleFactor_;
    public BancoDeDados bancoDeDados;
    public GameObject gameObjectOb;

    void Start() {
        larguraTela = Screen.width;
        gameObjectOb = GameObject.FindGameObjectWithTag("Bancodedados");
        bancoDeDados = gameObjectOb.GetComponent<BancoDeDados>();
        scaleFactor_ = bancoDeDados.GetEscala();
    }

    void Update() {
        canvas.scaleFactor = scaleFactor_;
    }

    public void AlteraEscala(float novaEscala) {
        scaleFactor_ = (larguraTela / 320) + novaEscala;
        bancoDeDados.escala = scaleFactor_;
    }

}
