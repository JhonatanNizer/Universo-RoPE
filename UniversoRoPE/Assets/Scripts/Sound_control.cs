using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_control : MonoBehaviour
{
    public AudioSource Start;
    public AudioSource TrocarMundo1;
    public AudioSource TrocarMundo2;
    public AudioSource TrocarMundo;
    public AudioSource TrocarFase;
    public AudioSource retorno;
    public AudioSource entrarNoMundo;
    public AudioSource ok03;
    // Start is called before the first frame update

    public void Start_()
    {
        Start.Play();
    }
    public void trocarmundo1_()
    {
        TrocarMundo1.Play();
    }
    public void trocarmundo2_()
    {
        TrocarMundo2.Play();
    }
    public void trocarmundo_()
    {
        TrocarMundo.Play();
    }
    public void trocarFase_()
    {
        TrocarFase.Play();
    }
    public void Retorno_()
    {
        retorno.Play();
    }
    public void Entrar()
    {
        entrarNoMundo.Play();
    }

    public void Ok03() {
        ok03.Play();
    }
}

