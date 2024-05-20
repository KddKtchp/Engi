using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public string message; // Mensaje que se mostrará al estar cerca del letrero
    public GameObject messageUI; // UI que mostrará el mensaje

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageUI.GetComponent<Text>().text = message;
            messageUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageUI.SetActive(false);
        }
    }
}
