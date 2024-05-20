using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damageAmount = 1; // Cantidad de da�o que inflige el enemigo

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si colisiona con el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Obtener el componente PlayerHealth del jugador
            PlayerHealthSystemHearts playerHealth = collision.gameObject.GetComponent<PlayerHealthSystemHearts>();
            
            // Verificar si el componente PlayerHealth existe
            if (playerHealth != null)
            {
                // Llamar a la funci�n TakeDamage() del jugador con el da�o especificado
                playerHealth.Hurt(damageAmount);
            }
        }
    }
}