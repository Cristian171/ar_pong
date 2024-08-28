using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LaunchBall();
    }

    void LaunchBall()
    {
        // Genera un vector de dirección inicial aleatorio
        float xDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float yDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        Vector3 direction = new Vector3(xDirection, yDirection, 0).normalized;

        // Aplica la velocidad al Rigidbody para mover la pelota
        rb.velocity = direction * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Aumenta la velocidad de la pelota ligeramente tras cada colisión
        rb.velocity = rb.velocity.normalized * (speed + 0.1f);
    }

    void Update()
    {
        // Mantén la velocidad constante
        rb.velocity = rb.velocity.normalized * speed;

        // Limita la velocidad máxima para evitar que se salga de control
        if (rb.velocity.magnitude > speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }
}
