using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f; // Velocidad de movimiento del enemigo
    public float moveDistance = 3f; // Distancia que el enemigo cubrirá de ida y vuelta

    private bool movingRight = true; // Variable para verificar la dirección del movimiento
    private Vector3 startPosition; // Posición inicial del enemigo

    void Start()
    {
        startPosition = transform.position; // Guardar la posición inicial del enemigo
    }

    void Update()
    {
        // Mover al enemigo de izquierda a derecha
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime); // Mover hacia la derecha
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime); // Mover hacia la izquierda
        }

        // Verificar si el enemigo ha alcanzado la distancia máxima de movimiento
        if (Mathf.Abs(transform.position.x - startPosition.x) >= moveDistance)
        {
            // Cambiar la dirección del movimiento
            movingRight = !movingRight;

            // Cambiar la dirección del sprite
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
        }
    }
}
