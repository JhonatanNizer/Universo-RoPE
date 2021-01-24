using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TExtControl : MonoBehaviour
{
    public int num_texto;
    public GameObject[] texto;
    public Animator movimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (num_texto == 0)
        {
            texto[0].SetActive(true);
        }
        if (num_texto == 1)
        {

            texto[1].SetActive(true);
            texto[0].SetActive(false);
        }
        if (num_texto == 2)
        {
            texto[2].SetActive(true);
            texto[1].SetActive(false);
        }
        if (num_texto == 3)
        {
            texto[3].SetActive(true);
            texto[2].SetActive(false);
        }
        if (num_texto == 4)
        {
            texto[4].SetActive(true);
            texto[3].SetActive(false);
        }
        if (num_texto == 5)
        {
            texto[5].SetActive(true);
            texto[4].SetActive(false);
        }
        if (num_texto == 6)
        {
            texto[6].SetActive(true);
            texto[5].SetActive(false);
        }
        if (num_texto == 7)
        {
            texto[7].SetActive(true);
            texto[6].SetActive(false);
        }
        if (num_texto == 8)
        {
            texto[8].SetActive(true);
            texto[7].SetActive(false);
        }
        if (num_texto == 9)
        {
            texto[9].SetActive(true);
            texto[8].SetActive(false);
        }
        if (num_texto == 10)
        {
            texto[10].SetActive(true);
            texto[9].SetActive(false);
        }
        if (num_texto == 11)
        {
            texto[11].SetActive(true);
            texto[10].SetActive(false);
        }
        if (num_texto == 12)
        {
            texto[12].SetActive(true);
            texto[11].SetActive(false);
        }
    }
  
    public void fexar()
    {
        movimento.SetInteger("movimento", 1);
    }

}
