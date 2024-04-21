using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    SpriteRenderer spriteRenderer;
    public Animator Coin;
    public int Objectvalue = 1;
    public coinmanager cm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            coinpickup inventory = other.GetComponent<coinpickup>();

            if (inventory != null)
            {
                inventory.objects = inventory.objects + Objectvalue;
                print("Player has" + inventory.objects + "objects in their inventory");
                gameObject.SetActive(false);
                cm.coinCount++;
            }
        }
    }
}
