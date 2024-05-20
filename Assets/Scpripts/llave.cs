using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door; // Referencia al objeto puerta

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Acciones a realizar cuando el jugador toca la llave
            if (door != null)
            {
                door.SetActive(false); // Desactivar la puerta si la referencia a la puerta no es nula
            }

            Destroy(gameObject); // Destruir la llave
        }
    }
}
