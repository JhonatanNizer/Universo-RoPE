using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toquenatelapariniciar : MonoBehaviour
{
    public GameObject logo;
    public GameObject botoesui;
    public GameObject Camera_;
    public Transform locais;
    public float tempo;
    public float redutordevelo;
    public int iniciou;
    public bool InicioJogo;
    public Transform iniciocamer;
    public BancoDeDados banco;
    public GameObject gameObjectOb;
    public GameObject tutorial;
    public sumirbotaoglobal sumirbotaoglobal;
    public GameObject ButTutorial;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectOb = GameObject.FindGameObjectWithTag("Bancodedados");
        banco = gameObjectOb.GetComponent<BancoDeDados>();
        ButTutorial.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        InicioJogo = banco.iniciou;
        if (InicioJogo)
        {
            Camera_.transform.position = iniciocamer.position;
            Camera_.transform.rotation = iniciocamer.rotation;

        }
        
            if (iniciou == 1)
            {
                tempo = tempo + Time.deltaTime / redutordevelo;
                Camera_.transform.position = Vector3.Lerp(Camera_.transform.position, locais.position, tempo);
                Camera_.transform.rotation = Quaternion.Lerp(Camera_.transform.rotation, locais.rotation, tempo);
            }
            
        if (tempo > 0.05)
        {

            if (banco.tutorial == false)
            {
                //botoesui.SetActive(false);
                //tutorial.SetActive(true);
                sumirbotaoglobal.enabled = false;
            }
            else
            {
                
                botoesui.SetActive(true);
                sumirbotaoglobal.enabled = true;
            }
        }
        if (tempo > 0.3)
        {
            this.gameObject.SetActive(false);
            


        }
   
    }
    public void iniciar()
    {
        iniciou = 1;
        ButTutorial.SetActive(true);


        InicioJogo = false;
        banco.iniciou = false;
    }
}
