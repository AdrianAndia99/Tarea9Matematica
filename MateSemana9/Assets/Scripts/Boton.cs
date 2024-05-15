using UnityEngine;

public class Boton : MonoBehaviour
{
    private bool gameStarted = false;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        if (!gameStarted)
        {
            Time.timeScale = 1;
            gameStarted = true;
        }
    }
}
