using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desligarraios : MonoBehaviour
{
    public GameObject raios;
    public GameObject areaparaligar;
    public GameObject botaodasativo;
    public AudioSource buttonclick1;
    public AudioSource somRaios;
    public controladorTextofese3 locais;

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
            raios.SetActive(false);
            areaparaligar.SetActive(true);
            botaodasativo.SetActive(true); 
            somRaios.Pause();
            buttonclick1.Play();
            locais.num += 1;
        }
    }
}
