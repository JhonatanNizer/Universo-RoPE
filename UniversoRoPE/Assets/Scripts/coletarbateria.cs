using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletarbateria : MonoBehaviour { 
    
    public Bateria_control bateria;
    public AudioSource itempick;

    public void OnTriggerEnter(Collider colisor) {
        if (colisor.tag == ("Player")) {
            bateria.energia_total = 10;
            this.gameObject.SetActive(false);
            itempick.Play();
        }
    }
}
