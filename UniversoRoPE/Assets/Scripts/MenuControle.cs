using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControle : MonoBehaviour {
    public AsyncOperation leitor;
    public bool loadgame;
    public bool carregar;
    public float tempo;
    public BancoDeDados bancoDeDados;
    public GameObject gameObjectOb;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectOb = GameObject.FindGameObjectWithTag("Bancodedados");
        bancoDeDados = gameObjectOb.GetComponent<BancoDeDados>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void abrirmenu()
    {
        menu.SetActive(true);

    }
    public void retornaraojogo()
    {
        this.gameObject.SetActive(false);

    }
    public void reiniciarFase()
    {
        if(bancoDeDados.cena==1 & bancoDeDados.mundo == 1)
        {
            leitor = SceneManager.LoadSceneAsync("fase 1.1");
        }
        if (bancoDeDados.cena == 1 & bancoDeDados.mundo == 2)
        {
            leitor = SceneManager.LoadSceneAsync("fase 2.1");
        }
        if (bancoDeDados.cena == 1 & bancoDeDados.mundo == 3)
        {
            leitor = SceneManager.LoadSceneAsync("fase 3.1");
        }


    }
    public void menuprincipal()
    {

        bancoDeDados.mundo = 1;
        bancoDeDados.cena = 1;
        leitor = SceneManager.LoadSceneAsync("Menu iniciar");
        
    }
    public void sairdojogo()
    {
        Application.Quit();
    }
    

}
