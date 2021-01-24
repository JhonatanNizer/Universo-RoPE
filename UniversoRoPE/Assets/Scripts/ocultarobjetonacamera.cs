using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocultarobjetonacamera : MonoBehaviour {
    public float tempo;

    void OnTriggerStay(Collider colisor) {
        if (colisor.gameObject.tag == "arvore1" || colisor.gameObject.tag == "arvore2" || colisor.gameObject.tag == "arvore3" || colisor.gameObject.tag == "arvore4") {
            colisor.gameObject.transform.localScale = new Vector3(colisor.gameObject.transform.localScale.x, Mathf.Lerp(colisor.gameObject.transform.localScale.y, 0.2f, tempo * Time.deltaTime), colisor.gameObject.transform.localScale.z);
            colisor.gameObject.GetComponent<crecerarvore>().crecer = false;
        }
    }

    void OnTriggerExit(Collider colisor) {
       if (colisor.gameObject.tag == "arvore1" || colisor.gameObject.tag == "arvore2" || colisor.gameObject.tag == "arvore3" || colisor.gameObject.tag == "arvore4") 
            colisor.gameObject.GetComponent<crecerarvore>().crecer = true;
    }
}
