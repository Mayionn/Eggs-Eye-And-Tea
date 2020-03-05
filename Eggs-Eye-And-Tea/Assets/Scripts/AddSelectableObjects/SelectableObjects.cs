using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObjects : MonoBehaviour
{

    public void Start()
    {
        GetComponent<cakeslice.Outline>().enabled = false;
    }

    public void OnMouseOver()
    {                              
        GetComponent<cakeslice.Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
        GetComponent<cakeslice.Outline>().enabled = false;
    }
}

