using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class fadedobrilho : MonoBehaviour
{
    public float starttime;
    public float velo;
    public MeshRenderer meshRenderer;
    public Color cor1;
    public Color cor2;
    public bool repetir;
    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!repetir)  
            {
            float t = (Time.time - starttime) * velo;
                meshRenderer.material.color = Color.Lerp(cor1, cor2, t);
            }
   
            else
            {
            float t = (Mathf.Sin(Time.time - starttime) * velo);
            meshRenderer.material.color = Color.Lerp(cor1, cor2, t);
             }
    }
}
