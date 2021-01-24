using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControlChar : MonoBehaviour {
    public AudioSource but1;
    public AudioSource but2;
    public AudioSource but3;
    public AudioSource but4;
    public AudioSource but5;
    public AudioSource but6;

    public AudioSource cameraCima;
    public AudioSource cameraReset;
    public AudioSource menuClick;
    // Start is called before the first frame update
    public void But1_()
    {
        but1.Play();
    }
    public void But2_()
    {
        but2.Play();
    }
    public void But3_()
    {
        but3.Play();
    }
    public void But4_()
    {
        but4.Play();
    }
    public void But5_()
    {
        but5.Play();
    }
    public void But6_()
    {
        but6.Play();
    }

    public void cameraCima_() {
        cameraCima.Play();
    }
    public void cameraReset_() {
        cameraReset.Play();
    }
    public void menuClick_() {
        menuClick.Play();
    }

}
