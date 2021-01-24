using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirnovobancodedados : MonoBehaviour
{
    public GameObject[] bancos;
    // Start is called before the first frame update
    void Start()
    {
        bancos = GameObject.FindGameObjectsWithTag("Bancodedados");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bancos.Length == 2)
            Destroy(bancos[1]);

    }
}
