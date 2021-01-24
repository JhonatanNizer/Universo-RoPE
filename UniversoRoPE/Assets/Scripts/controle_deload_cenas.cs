using UnityEngine;
using UnityEngine.SceneManagement;

public class controle_deload_cenas : MonoBehaviour
{
    public AsyncOperation leitor;
    public bool loadgame;
    public bool carregar;
    public float tempo;
    public selecionar_fase_mundo mundo1;
    public selecionar_fase_mundo mundo2;
    public selecionar_fase_mundo mundo3;
    public int mundo;
    public GameObject carregando;
    public GameObject mao;
    public GameObject mundos;
    // public GameObject telaload;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(loadgame==true)
        {
            mao.SetActive(false);
            tempo = tempo + Time.deltaTime;
         //   telaload.SetActive(true);
        }


        if (mundo == 1)
        {
            if (carregar == true && mundo1.faseatual == 1)
            {
                leitor = SceneManager.LoadSceneAsync("fase 1.1");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
            if (carregar == true && mundo1.faseatual == 2)
            {
                leitor = SceneManager.LoadSceneAsync("fase 1.2");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
            if (carregar == true && mundo1.faseatual == 3)
            {
                leitor = SceneManager.LoadSceneAsync("fase 1.3");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
        }
        if (mundo == 2)
        {
            if (carregar == true && mundo2.faseatual == 1)
            {
                leitor = SceneManager.LoadSceneAsync("fase 2.1");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
            if (carregar == true && mundo2.faseatual == 2)
            {
                leitor = SceneManager.LoadSceneAsync("fase 2.2");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
            if (carregar == true && mundo2.faseatual == 3)
            {
                leitor = SceneManager.LoadSceneAsync("fase 3.3");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
        }
        if (mundo == 3)
        {
            if (carregar == true && mundo3.faseatual == 1)
            {
                leitor = SceneManager.LoadSceneAsync("fase 3.1");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
            if (carregar == true && mundo3.faseatual == 2)
            {
                leitor = SceneManager.LoadSceneAsync("fase 3.2");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
            if (carregar == true && mundo3.faseatual == 3)
            {
                leitor = SceneManager.LoadSceneAsync("fase 3.3");
                // leitor.allowSceneActivation = false;
                carregar = false;
            }
        }

        // if (tempo > 2)
        //   leitor.allowSceneActivation = true;
    }
    public void entrar_na_fase1()
    {
        mao.SetActive(false);
        mundos.SetActive(false);
        carregando.SetActive(true);
        mundo = 1;
        carregar = true;
        loadgame = true;
        
    }
    public void entrar_na_fase2()
    {
        mundos.SetActive(false);
        mao.SetActive(false);
        carregando.SetActive(true);
        mundo = 2;
        carregar = true;
        loadgame = true;
        

    }
    public void entrar_na_fase3()
    {
        mundos.SetActive(false);
        mao.SetActive(false);
        carregando.SetActive(true);
        mundo = 3;
        carregar = true;
        loadgame = true;
        

    }
}
