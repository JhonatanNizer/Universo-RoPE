using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorTextofese3 : MonoBehaviour
{
    public int num;
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
        if(num>=5&&trava==false)
        {
            texto.num_texto += 1;
            anime.SetInteger("movimento", 0);
            trava = true;
        }

    }

}
