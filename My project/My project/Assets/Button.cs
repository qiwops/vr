using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Capsule;
    public GameObject Cube;
    
    public void onClick()
    {
        if (Capsule.activeSelf)
        {
            Capsule.SetActive(false);
            Cube.SetActive(false);
        }
        else
        {
            Capsule.SetActive(true);
            Cube.SetActive(true);
        }
    }
}
