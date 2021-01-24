using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class coletarlixo : MonoBehaviour {
    public lixosnocenario script;
    public AudioSource coletalixo;
    public TExtControl texto;
    public bool pegouUmaVez;
    public coletarlixo[] coletarlixoArray;
    public Animator movimento;

    public void OnTriggerEnter(Collider colisor) {
        if (colisor.tag == ("Player") && script.possui_aspirador==true) {

            if(pegouUmaVez == false) {
               texto.num_texto = texto.num_texto + 1;
               pegouUmaVez = true;
                foreach(coletarlixo membro in coletarlixoArray) {
                    membro.pegouUmaVez = true;
                }
                movimento.SetInteger("movimento", 0);
            }
            
            script.total = script.total - 1;
            script.totalAcumulado++;
            Destroy(this.gameObject);
            coletalixo.Play();
        }
    }
}
