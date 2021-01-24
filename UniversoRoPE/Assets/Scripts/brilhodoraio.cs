using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brilhodoraio : MonoBehaviour
{
    public float frequancia;
    public Light luz;
    public float força;
    public bool ciclo;
    public float tempo;
  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;
        if (tempo >= frequancia)
            ciclo = true;
        if(tempo>frequancia*2)
        {
            ciclo = false;
            tempo = 0;
        }    
        if (ciclo==false)
            luz.intensity = Mathf.Lerp(4,10, força* Time.deltaTime);
            if(ciclo==true)
            luz.intensity = Mathf.Lerp(10, 4, força * Time.deltaTime);
                
   
        
    }
}
