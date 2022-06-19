using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_2DCoins : MonoBehaviour
{
    // Start is called before the first frame update
    public static int totalCoins = 0;

    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
            totalCoins++;
            //Test: Print total number of coins
            //Debug.Log("You currently have " + SC_2DCoins.totalCoins + " Coins.");
            //Destroy coin
            Destroy(gameObject);
        }
    }
}
