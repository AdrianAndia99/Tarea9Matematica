using UnityEngine;
using UnityEngine.SceneManagement;
public class CodigoMRUV : MonoBehaviour
{
    public float initialSpeed;
    public float acceleration;
    private Rigidbody rb;

    private bool isMoving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.right * initialSpeed;
    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            rb.velocity += transform.right * acceleration * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "reinicio")
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Jugador2 llego primero");
            Time.timeScale = 0f;
        }
    }
}