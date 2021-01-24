using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverperssonagem : MonoBehaviour
{
    public GameObject rope;
    public Rigidbody camera;
    public float tempo;

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;

        if(tempo>=3 && tempo<=3.3f)
        {
            camera.velocity = new Vector3(Mathf.Lerp(0, 3, 1), 0, 0);
        }
        if (tempo >= 6 && tempo <= 6.3f)
        {
            camera.velocity = new Vector3(Mathf.Lerp(0, 3, 1), 0, 0);
        }
        if (tempo >= 10 && tempo <= 10.3f)
        {
            camera.velocity = new Vector3(Mathf.Lerp(0, 3, 1), 0, 0);
        }


    }
    public void andar ()
    {
        camera.velocity = new Vector3(Mathf.Lerp(0, 3, 1), 0, 0);
    }
    public void andar2()
    {
        camera.velocity = new Vector3(Mathf.Lerp(0, -3, 1), 0, 0);
    }
}
