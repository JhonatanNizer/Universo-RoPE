using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class botaocontinuo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public float input;
    public float sensibility = 3;
    bool pressing;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }

    void Update()
    {
        if (pressing)
        {
            input += Time.deltaTime * sensibility;
        }
        else
        {
            input -= Time.deltaTime * sensibility;
        }
        input = Mathf.Clamp(input, 0, 1);
    }
}
