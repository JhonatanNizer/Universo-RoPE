using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecionarplaneta : MonoBehaviour
{
    public GameObject Camera_;
    public Transform[] locais;
    public int local;
    public float tempo;
    public float redutordevelo;
    public float tempo2;
    public GameObject touch;
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
        tempo2 = tempo2 + Time.deltaTime;
        if (tempo2 > 3)
            touch.SetActive(true);
        else
            touch.SetActive(false);
        if (local>2)
        {
            local = 0;
        }
        if (local < 0)
        {
            local = 2;
        }

        if (local == 0)
        {
            tempo = tempo + Time.deltaTime / redutordevelo;
            Camera_.transform.position = Vector3.Lerp(Camera_.transform.position, locais[0].position, tempo);
            Camera_.transform.rotation = Quaternion.Lerp(Camera_.transform.rotation, locais[0].rotation, tempo);
           
        }
        if (local == 1)
        {
            tempo = tempo + Time.deltaTime / redutordevelo;
            Camera_.transform.position = Vector3.Lerp(Camera_.transform.position, locais[1].position, tempo);
            Camera_.transform.rotation = Quaternion.Lerp(Camera_.transform.rotation, locais[1].rotation, tempo);

        }
        if (local == 2)
        {
            tempo = tempo + Time.deltaTime / redutordevelo;
            Camera_.transform.position = Vector3.Lerp(Camera_.transform.position, locais[2].position, tempo);
            Camera_.transform.rotation = Quaternion.Lerp(Camera_.transform.rotation, locais[2].rotation, tempo);

        }
    }
    public void avançar()
    {
        local = local + 1;
        tempo = 0;
        tempo2 = 0;
        bancoDeDados.mundo += 1;
    }
    public void voltar()
    {
        local = local - 1;
        tempo = 0;
        tempo2 = 0;
        bancoDeDados.mundo-= 1;
    }
}
