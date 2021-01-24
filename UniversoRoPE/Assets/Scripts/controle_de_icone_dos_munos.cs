using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle_de_icone_dos_munos : MonoBehaviour
{
    public GameObject[] icones;
    public selecionar_fase_mundo numerodacamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(numerodacamera.faseatual==1)
        {
            icones[0].SetActive(true);
            icones[1].SetActive(false);
            icones[2].SetActive(false);
        }
        if (numerodacamera.faseatual == 2)
        {
            icones[0].SetActive(false);
            icones[1].SetActive(true);
            icones[2].SetActive(false);
        }
        if (numerodacamera.faseatual == 3)
        {
            icones[0].SetActive(false);
            icones[1].SetActive(false);
            icones[2].SetActive(true);
        }
    }

}
