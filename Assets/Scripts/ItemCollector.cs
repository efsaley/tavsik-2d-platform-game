using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int pineapples = 0;
    [SerializeField] private Text PineapplesCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("pineapple"))
        {
            Destroy(collision.gameObject);
            pineapples++;
            PineapplesCount.text = "Pineapples: " + pineapples; 
        }
        
    }
}
