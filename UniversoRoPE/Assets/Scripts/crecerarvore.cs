using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crecerarvore : MonoBehaviour
{
    public float tempo;
    public bool crecer;
    public float tamanho;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(crecer==true)
      transform.localScale = new Vector3(transform.localScale.x, Mathf.Lerp(transform.localScale.y, tamanho, tempo * Time.deltaTime ),transform.localScale.z);
    }
}
