using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girarcameranomundo : MonoBehaviour
{
    public float tempo = 0;
    public float velo1;
    public float velo2;

    public bool vai=true;
    public Quaternion pose1;
    public Quaternion pose2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;


        if (tempo<5)
        {
            velo1 = velo1 + Time.deltaTime/5;
            transform.rotation = Quaternion.Lerp(pose1, pose2, velo1 );
        }

        if (tempo > 5)
        {
            velo2 = velo2 + Time.deltaTime / 5;
            transform.rotation = Quaternion.Lerp(pose2, pose1, velo2);
        }
        if (tempo > 10)
        {
            tempo = 0;
            velo1 = 0;
            velo2 = 0;
        }
    }
}
