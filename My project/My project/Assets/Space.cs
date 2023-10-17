using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space : MonoBehaviour
{
    public GameObject Capsule;
    public GameObject Cube;
    public Text myText;
    private int i = 0;

    public void setText(string newText)
    {
        myText.text = newText;
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            i += 1;
            Capsule.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV();
            Cube.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV();
            setText("Нажатий: " + i);
        }
    }
}
