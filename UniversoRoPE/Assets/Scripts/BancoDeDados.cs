using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BancoDeDados : MonoBehaviour
{
    public bool[] faseCompleta;
    public GameObject estrela;
    public int cena;
    public int mundo;
    public Image estrelaimage;
    public bool entrou;
    public bool iniciou;
    public bool AtivarSaveELoadGame;
    private bool carregargame;
    private int fase1;
    private int fase2;
    private int fase3;
    private int tuteint;
    public bool tutorial;
    public float escala;
    //public CanvasEscala CanvasEscala;
    // Start is called before the first frame update
    void Start() {
        DontDestroyOnLoad(this.gameObject);
        carregargame = true;
        escala = Screen.width / 320;

        PlayerPrefs.SetFloat("escala", escala);
    }

    // Update is called once per frame
    void Update() {
        estrela = GameObject.FindGameObjectWithTag("estrela 1");
        estrelaimage = estrela.GetComponent<Image>();
        if (cena > 3)
            cena = 1;
        if (cena <1)
            cena = 3;

        if (mundo > 3)
            mundo = 1;
        if (mundo < 1)
            mundo = 3;


        if (entrou)
        {
            iniciou = false;
            if (mundo == 1)
            {
                if (cena == 1)
                {
                    if (faseCompleta[0] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }
                if (cena == 2)
                {
                    if (faseCompleta[4] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }
                if (cena == 3)
                {
                    if (faseCompleta[6] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }

            }




            if (mundo == 2)
            {
                if (cena == 1)
                {
                    if (faseCompleta[3] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }
                if (cena == 2)
                {
                    if (faseCompleta[4] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }
                if (cena == 3)
                {
                    if (faseCompleta[5] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }

            }



            if (mundo == 3)
            {
                if (cena == 1)
                {
                    if (faseCompleta[6] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }
                if (cena == 2)
                {
                    if (faseCompleta[7] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }
                if (cena == 3)
                {
                    if (faseCompleta[8] == true)
                        estrelaimage.enabled = true;
                    else
                        estrelaimage.enabled = false;
                }

            }
        }
        else
            estrelaimage.enabled = false;



        //save game
        if (AtivarSaveELoadGame)
        {
            // load
            fase1= PlayerPrefs.GetInt("fase1");
            fase2 = PlayerPrefs.GetInt("fase2");
            fase3 = PlayerPrefs.GetInt("fase3");
            tuteint = PlayerPrefs.GetInt("tute");
            //escala = PlayerPrefs.GetFloat("escala");
            if (carregargame)
            {
                if (fase1 == 1)
                    faseCompleta[0] = true;
                else
                    faseCompleta[0] = false;

                if (fase2 == 1)
                    faseCompleta[1] = true;
                else
                    faseCompleta[1] = false;

                if (fase3 == 1)
                    faseCompleta[2] = true;
                else
                    faseCompleta[2] = false;

                if (tuteint == 1)
                    tutorial = true;
                else
                    tutorial = false;

                carregargame = false;
            }
            if (carregargame == false)
            {
                if (faseCompleta[0] == true)
                    fase1 = 1;
                else
                    fase1 = 0;

                if (faseCompleta[3] == true)
                    fase2 = 1;
                else
                    fase2 = 0;

                if (faseCompleta[6] == true)
                    fase3 = 1;
                else
                    fase3 = 0;
                if (tutorial == true)
                    tuteint = 1;
                else
                    tuteint = 0;
            }
            // save
            PlayerPrefs.SetInt("fase1", fase1);
            PlayerPrefs.SetInt("fase2", fase2);
            PlayerPrefs.SetInt("fase3", fase3);
            PlayerPrefs.SetInt("tute", tuteint);
            PlayerPrefs.SetInt("tute", tuteint);
            PlayerPrefs.SetFloat("escala", escala);

        }
    }

    public float GetEscala() {
        return PlayerPrefs.GetFloat("escala");
        //return escala * 0.90f;
    }
    
   
}
