using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contraladordepetalas : MonoBehaviour
{ public Transform petalas;
    public GameObject[] flor;
    private float tempo;
    public Transform lugar;
    [Range(0f,2f)]
    public float frequancia;
    private float pontox;
    private float pontoz;
    private float tempo2;
    public float maximox;
    public float maximoy;
    public float minimox;
    public float minimoy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;
        tempo2 = tempo2 + Time.deltaTime;
        if (tempo2 < 3)
        {
            if (tempo >= frequancia)
            {
                pontox = Random.Range(minimox, maximox);
                pontoz = Random.Range(minimoy, maximoy);
                Instantiate(flor[0], (lugar.position), Quaternion.identity,petalas);
                transform.position = new Vector3(pontox, 10, pontoz);
                tempo = 0;
            }
        }
        if (tempo2 >= 6)
            tempo2 = 0;
        
    }
}
