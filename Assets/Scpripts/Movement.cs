using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    public float jumpForce = 10f; // Fuerza del salto
    private Rigidbody2D rb;
    private bool isGrounded; // Variable para verificar si el jugador está en el suelo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Cambiar la dirección del sprite según la dirección del movimiento
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
        }

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // Verifica si el jugador está en el suelo antes de saltar
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    public void ForcedJump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    [Header("animation")]
    private Animator animator; //parte de la animacion xd


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el jugador está en el suelo al tocar un objeto con el tag "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Verificar si el jugador ya no está en el suelo al salir del objeto con el tag "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

    }
}
