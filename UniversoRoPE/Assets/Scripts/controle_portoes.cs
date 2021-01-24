using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle_portoes : MonoBehaviour
{
    public GameObject raio;
    public bool subir;
    public bool baixar;
    public float tempo;
    public float tempo1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (raio.activeSelf == true)
        {
            baixar = true;
            subir = false;
        }
        else
        {
            baixar = false;
            subir = true;
        }

        if (baixar == true)
        {
            tempo = tempo + Time.deltaTime;
            this.gameObject.transform.localPosition = new Vector3(0, Mathf.Lerp(0, -2, tempo), 0);
            tempo1 = 0;
        }
        if (subir == true&& this.gameObject.transform.localPosition.y!=0) {
            tempo1 = tempo1 + Time.deltaTime;
            this.gameObject.transform.localPosition = new Vector3(0, Mathf.Lerp(-2, 0, tempo1), 0);
            tempo = 0;
        }


    }
}
