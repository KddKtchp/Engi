using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject key; // Referencia al objeto llave
    public GameObject door; // Referencia al objeto puerta
    private bool isDoorOpen = true; // Variable para verificar si la puerta está abierta

    void Start()
    {
        door.SetActive(isDoorOpen); // Activar la puerta al inicio del juego
    }

    void Update()
    {
        if (key == null && isDoorOpen) // Si no hay llave en el juego y la puerta está abierta
        {
            door.SetActive(false); // Desactivar la puerta
            isDoorOpen = false; // Actualizar el estado de la puerta a cerrada
            Debug.Log("¡La puerta se ha Abierto!"); // Agregar un mensaje de depuración
        }
    }
}
