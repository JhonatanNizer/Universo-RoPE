using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chamarportalmundo2 : MonoBehaviour
{
    public ativarmangeira[] mangueiras;
    public int total;
    public int ativadas;
    public bool[] ativabloc;
    public GameObject portal;
    public TExtControl texto;
    private bool trava;
    public Animator movimento;
    // Start is called before the first frame update
    void Start()
    {
        total = mangueiras.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < total; i++)
        {
            if (mangueiras[i].molhar == true && ativabloc[i]==false)
            {
                ativadas += 1;
                ativabloc[i] = true;
            }
        }


        if(ativadas==total && trava==false)
        {
            portal.SetActive(true);
            texto.num_texto += 1;
            movimento.SetInteger("movimento", 0);
            trava = true;
        }
        

    }
}
