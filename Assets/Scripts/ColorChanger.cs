using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material enterMaterial; 
    public Material exitMaterial;  

    private void OnTriggerEnter(Collider other)
    {
        Material mat = GetComponent<Renderer>().material;
        mat.color = enterMaterial.color;
    }
    private void OnTriggerExit(Collider other)
    {
        Material mat = GetComponent<Renderer>().material;
        mat.color = exitMaterial.color;
    }
}
