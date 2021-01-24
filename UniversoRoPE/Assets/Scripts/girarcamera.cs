using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girarcamera : MonoBehaviour
{
    public GameObject camera;
    public botaocontinuo esquerda;
    public botaocontinuo direita;
    public botaocontinuo centro;
    public botaocontinuo topo;
    public float velo;
    public Quaternion zero;
    public Quaternion topo_;
    public Vector3 posetopo1;
    public Vector3 posetopo2;
    public Vector3 posetopo3;
    public Vector3 retorno;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (centro.input > 0.000001)
        {
            camera.transform.rotation = (zero);
            camera.transform.localPosition = (retorno);
            num = 0;
        }
        if (num > 3)
            num = 1;
        if(esquerda.input>0.2)
        {
            camera.transform.Rotate(0, -velo * Time.deltaTime, 0, Space.World);
        }
        if (direita.input > 0.2)
        {
            camera.transform.Rotate(0, velo * Time.deltaTime, 0, Space.World);
        }
        
        if (num==1)
        {
            camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, topo_, velo * Time.deltaTime);
            camera.transform.localPosition = Vector3.Lerp(camera.transform.localPosition, posetopo1, velo * Time.deltaTime);
        }
        if (num == 2)
        {
            camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, topo_, velo * Time.deltaTime);
            camera.transform.localPosition = Vector3.Lerp(camera.transform.localPosition, posetopo2, velo * Time.deltaTime);
        }
        if (num == 3)
        {
            camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, topo_, velo * Time.deltaTime);
            camera.transform.localPosition = Vector3.Lerp(camera.transform.localPosition, posetopo3, velo * Time.deltaTime);
        }


    }
    public void add()
    {
        num += 1;
    }
}
