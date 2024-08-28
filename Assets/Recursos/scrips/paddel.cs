using UnityEngine;

public class Paddel : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Obtener la entrada del usuario en los ejes X e Y
        float moveX = Input.GetAxis("Horizontal"); // Mueve la paleta en el eje X (izquierda y derecha)
        float moveY = Input.GetAxis("Vertical");   // Mueve la paleta en el eje Y (arriba y abajo)

        // Movimiento en el eje Z (Opcional, si decides usarlo)
        float moveZ = 0f;
        if (Input.GetKey(KeyCode.W)) // Presiona W para mover hacia adelante
        {
            moveZ = 1f;
        }
        else if (Input.GetKey(KeyCode.S)) // Presiona S para mover hacia atrás
        {
            moveZ = -1f;
        }

        // Crear el vector de movimiento combinando X, Y y Z
        Vector3 movement = new Vector3(moveX, moveY, moveZ).normalized * speed * Time.deltaTime;

        // Aplicar el movimiento a la posición de la paleta
        transform.Translate(movement);
    }
}
