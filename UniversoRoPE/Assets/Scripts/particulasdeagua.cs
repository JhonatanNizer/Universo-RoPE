using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particulasdeagua : MonoBehaviour
{
    public float tempo;
    public ParticleSystem particula;
    public int maximo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo+Time.deltaTime;
            particula.gravityModifier = Mathf.Lerp(0.09f,0.01f,tempo/2);
        if (tempo > 3)
            particula.Stop();

        

    }
}
