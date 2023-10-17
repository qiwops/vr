using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Text myText;
    public int hp;
    public int damage;
    public GameObject Self;

    public void setText(string newText)
    {
        myText.text = newText;
    }

    private void OnTriggerEnter(Collider Bullet)
    {
        if (Bullet.CompareTag("Bullet"))
        {
            hp -= damage;
            setText("HP: " + hp);
        }
    }
    
    void FixedUpdate()
    {
        if (hp <= 0)
        {
            Destroy(Self);
        }
    }
}
