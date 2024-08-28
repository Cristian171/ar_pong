using UnityEngine;

public class MovePaddle : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Obtener la entrada del usuario en los ejes X e Y
        float moveX = Input.GetAxis("Horizontal"); // Mueve la paleta en el eje X (izquierda y derecha)
        float moveY = Input.GetAxis("Vertical");   // Mueve la paleta en el eje Y (arriba y abajo)

        // Crear el vector de movimiento y normalizarlo para evitar velocidades incontrolables
        Vector3 movement = new Vector3(moveX, moveY, 0).normalized * speed * Time.deltaTime;

        // Aplicar el movimiento a la posición de la paleta
        transform.Translate(movement);
    }
}
