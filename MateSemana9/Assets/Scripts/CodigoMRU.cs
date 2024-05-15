using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoMRU : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector2 initialPosition;
    private bool isMoving = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "reinicio")
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Jugador1 llego primero");
            Time.timeScale = 0f;
        }
    }

    private void ToggleMovement()
    {
        if (isMoving)
        {
            rb.velocity = Vector2.zero;
            transform.position = initialPosition;
        }
        else
        {
            rb.velocity = new Vector2(speed, 0);
        }
        isMoving = !isMoving;
    }
}