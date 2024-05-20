using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; // La salud m�xima del jugador
    private int currentHealth; // La salud actual del jugador

    public Text healthText; // Referencia al texto que muestra la salud en la interfaz (aseg�rate de asignarlo en el Inspector)

    void Start()
    {
        currentHealth = maxHealth; // Inicializar la salud actual al m�ximo al inicio del juego
        UpdateHealthText(); // Actualizar el texto de la salud en la interfaz
    }

    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Salud: " + currentHealth.ToString(); // Actualizar el texto de la salud
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Reducir la salud actual por la cantidad de da�o recibido
        UpdateHealthText(); // Actualizar el texto de la salud en la interfaz

        if (currentHealth <= 0)
        {
            Die(); // Si la salud llega a cero o menos, llamar a la funci�n de muerte
        }
    }

    void Die()
    {
        // Aqu� puedes agregar cualquier l�gica adicional relacionada con la muerte del jugador
        Debug.Log("�Has muerto!");
        // Por ejemplo, puedes desactivar el GameObject del jugador o reiniciar el nivel
        gameObject.SetActive(false);
    }
}
