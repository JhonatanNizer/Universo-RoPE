using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animaçãoblack : MonoBehaviour
{
    public Animator anime;
    public AsyncOperation leitor;
    public bool carregar;
    public float tempo;
    public GameObject menu;
    
    // Start is called before the first frame update
    void Start()
    {
        
        anime.SetBool("black", true);
    }

    // Update is called once per frame
    void Update()
    {
       
            tempo = tempo + Time.deltaTime;

        if (tempo>3)
        {
            menu.SetActive(true);
        }
    }
}
