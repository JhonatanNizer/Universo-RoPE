using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecionar_fase_mundo : MonoBehaviour
{
    public GameObject Camera_;
    public selecionarplaneta controleglobal;
    public selecionar_fase_mundo controleinterno;
    public int faseatual;
    public float tempo;
    public float redutordevelo;
    public Transform[] locais;
    public GameObject[] icone;
    public GameObject botao_some;
    public GameObject botao_some2;
    public GameObject botao_aparece;
    public bool entrou;
    public GameObject desenvolvimento;
    public GameObject toqueinicio;
    public BancoDeDados bancoDeDados;
    public GameObject gameObjectOb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        gameObjectOb = GameObject.FindGameObjectWithTag("Bancodedados");
        bancoDeDados = gameObjectOb.GetComponent<BancoDeDados>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (entrou==true)
        {
            if (faseatual > 3)
            faseatual = 1;
        if (faseatual < 1)
            faseatual = 3;

            



            if (faseatual == 1)
        {
                toqueinicio.SetActive(true);
                desenvolvimento.SetActive(false);
                  tempo = tempo + Time.deltaTime / redutordevelo;
            Camera_.transform.position = Vector3.Lerp(Camera_.transform.position, locais[0].position, tempo);
            Camera_.transform.rotation = Quaternion.Lerp(Camera_.transform.rotation, locais[0].rotation, tempo);
        }
          if (faseatual == 2)
            {
                desenvolvimento.SetActive(true);
                toqueinicio.SetActive(false);
                tempo = tempo + Time.deltaTime / redutordevelo;
                Camera_.transform.position = Vector3.Lerp(Camera_.transform.position, locais[1].position, tempo);
                Camera_.transform.rotation = Quaternion.Lerp(Camera_.transform.rotation, locais[1].rotation, tempo);
            }
            if (faseatual == 3)
            {
                desenvolvimento.SetActive(true);
                toqueinicio.SetActive(false);
                tempo = tempo + Time.deltaTime / redutordevelo;
                Camera_.transform.position = Vector3.Lerp(Camera_.transform.position, locais[2].position, tempo);
                Camera_.transform.rotation = Quaternion.Lerp(Camera_.transform.rotation, locais[2].rotation, tempo);
            }

            if (faseatual == 1)
        {
            icone[0].SetActive(true);
            icone[1].SetActive(false);
            icone[2].SetActive(false);

        }
        if (faseatual == 2)
        {
            icone[0].SetActive(false);
            icone[1].SetActive(true);
            icone[2].SetActive(false);

        }
        if (faseatual == 3)
        {
            icone[0].SetActive(false);
            icone[1].SetActive(false);
            icone[2].SetActive(true);
        }
    }

    }
    
    public void entrarmundo()
    {
        tempo = 0;
        faseatual = 1;
        controleinterno.enabled = true;
        botao_aparece.SetActive(true);
        botao_some.SetActive(false);
        botao_some2.SetActive(false);
        entrou = true;
        controleglobal.enabled = false;
        bancoDeDados.entrou = true;

    }
    public void avançar()
    {
        faseatual += 1;
        tempo = 0;
        bancoDeDados.cena += 1;
    }
    public void voltar()
    {
        faseatual -= 1;
        tempo = 0;
        bancoDeDados.cena -= 1;
    }
   public void retornar()
    {
        toqueinicio.SetActive(false);
        desenvolvimento.SetActive(false);
        controleglobal.enabled = true;
        controleinterno.enabled = false;
        botao_aparece.SetActive(false);
        botao_some.SetActive(true);
        botao_some2.SetActive(true);
        entrou = false;
        icone[0].SetActive(false);
        icone[1].SetActive(false);
        icone[2].SetActive(false);
        bancoDeDados.entrou = false;
    }
}
