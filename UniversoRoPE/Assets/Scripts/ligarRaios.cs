using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligarRaios : MonoBehaviour { 
    public GameObject Raios;
    public GameObject botaodasativo;
    public AudioSource somRaio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    public void OnTriggerEnter(Collider colisor)
    {
        if (colisor.tag == ("Player"))
        {
            Raios.SetActive(true);
            this.gameObject.SetActive(false);
            botaodasativo.SetActive(false);
            somRaio.Play();
        }
    }
}
