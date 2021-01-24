using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chamarUltimotextoFaseFinal : MonoBehaviour
{
    public TExtControl texto;
    private bool trava;
    public Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            if (trava == false)
            { 
                texto.num_texto += 1;
                anime.SetInteger("movimento", 0);
                trava = true;
            }
        }
            
    }
}
