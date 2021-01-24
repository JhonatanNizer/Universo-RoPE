using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class excluirobjetocomtempo : MonoBehaviour
{private float tempo;
    public float quando;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;

        if (tempo >= quando)
            DestroyObject(this.gameObject);
    }
}
