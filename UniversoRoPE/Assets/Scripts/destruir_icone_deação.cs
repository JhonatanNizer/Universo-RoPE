using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class destruir_icone_deação : MonoBehaviour {
    public AudioSource destruirIcone;
    public GameObject destruirIconeObjeto;
    public GameObject script;
    public girarengrenagens girarengrenagens;
    public GameObject scriptUi;
    public UiControladora uiControladora;
    public GameObject deletaComando;

    public int posicaoNaLista;
    
    void Start() {
        destruirIconeObjeto = GameObject.FindWithTag("AudioTag");
        destruirIcone = destruirIconeObjeto.GetComponent<AudioSource>();
        scriptUi = GameObject.FindWithTag("UiControladora");
        uiControladora = scriptUi.GetComponent<UiControladora>();
        script = GameObject.FindWithTag("engrenagens");
        girarengrenagens = script.GetComponent<girarengrenagens>();
        deletaComando = GameObject.FindWithTag("DeletaComando");
        posicaoNaLista = uiControladora.ListaComandos.Count;
    }

    void Update() {
        if (uiControladora.ListaComandossGrafico.Count == 0) {
            DestruirObjeto();
            deletaComando.SetActive(false);
            deletaComando.transform.position = new Vector3(-179.060f, 5.369969f, -3.56634f);
        }
        if (posicaoNaLista == uiControladora.ListaComandossGrafico.Count) {
            deletaComando.transform.position = this.transform.position;
        }
        

    }

    public void OnClick() {
        if (uiControladora.ListaComandossGrafico.Count == 1) {
            deletaComando.SetActive(false);
        }

        if (posicaoNaLista == uiControladora.ListaComandossGrafico.Count) { 
            DestruirObjeto(posicaoNaLista - 1);
        }
    }

    public void DestruirObjeto() {
        destruirIcone.Play();
        Destroy(this.gameObject);
        
    }

    public void DestruirObjeto(int pos) {


        destruirIcone.Play();
        uiControladora.ListaComandos.RemoveAt(pos);
        uiControladora.ListaComandossGrafico.RemoveAt(pos);
        Destroy(this.gameObject);
    }

}
