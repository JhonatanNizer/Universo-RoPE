using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConcluirFase : MonoBehaviour {
    public int fazeAtual;
    //de 0 a 8
    public AsyncOperation leitor;
    public BancoDeDados bancoDeDados;
    public GameObject gameObjectOb;
    //public Animator anime;
    public GameObject menu;
    public AudioSource completaFase;
    public AudioSource musicaPrincipal;
    
    void Start() {
        gameObjectOb = GameObject.FindGameObjectWithTag("Bancodedados");
        bancoDeDados = gameObjectOb.GetComponent<BancoDeDados>();
    }

    public void OnTriggerEnter(Collider colisor) {
        if (colisor.tag == ("Player")) {
            musicaPrincipal.Stop();
            menu.SetActive(true);
            //anime.SetBool("portal", true);
            bancoDeDados.faseCompleta[fazeAtual] = true;
            
            completaFase.Play();


        }
    }
}
