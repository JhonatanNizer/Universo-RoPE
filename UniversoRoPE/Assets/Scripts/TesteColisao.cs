using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteColisao : MonoBehaviour {

    public bool EstaColidindo;
    

    public void Update() {
        
       
    }

    public void OnTriggerStay(Collider colisor) {
        if (colisor.gameObject.CompareTag("Colisor")) {
            EstaColidindo = true;
        } 
        
    }

    public void OnTriggerExit(Collider colisor) {  
        EstaColidindo = false;
    }

}
