using UnityEngine;
using Vuforia;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public GameObject imageTarget; // Asigna el ImageTarget en el Inspector de Unity
    private Vector3 targetSize;

    void Start()
    {
        // Obtener las dimensiones del ImageTarget
        if (imageTarget != null)
        {
            targetSize = imageTarget.GetComponent<ImageTargetBehaviour>().GetSize();
        }
        else
        {
            Debug.LogError("ImageTarget no asignado en el inspector.");
        }
    }

    void Update()
    {
        // Obtener la entrada del usuario
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Movimiento en el plano X-Y
        Vector3 movement = new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;

        // Aplicar el movimiento
        transform.Translate(movement);

        // Limitar el movimiento dentro de las dimensiones del target
        float clampedX = Mathf.Clamp(transform.localPosition.x, -targetSize.x / 2, targetSize.x / 2);
        float clampedY = Mathf.Clamp(transform.localPosition.y, -targetSize.y / 2, targetSize.y / 2);

        transform.localPosition = new Vector3(clampedX, clampedY, transform.localPosition.z);
    }
}
