using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    private float moveInput;

    void Update()
    {
        // Obtener la entrada horizontal del usuario
        moveInput = Input.GetAxis("Horizontal");
        // Mover el paddle horizontalmente
        transform.Translate(Vector3.right * moveInput * speed * Time.deltaTime);
    }
}
