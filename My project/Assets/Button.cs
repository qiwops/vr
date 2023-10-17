using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Cube;
    
    public void onClick()
    {
        if (Sphere.activeSelf)
        {
            Sphere.SetActive(false);
            Cube.SetActive(false);
        }
        else
        {
            Sphere.SetActive(true);
            Cube.SetActive(true);
        }
    }
}
