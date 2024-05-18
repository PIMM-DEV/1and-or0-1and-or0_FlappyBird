using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] GameOverManager gameOverManager;
    void Update()
    {
        if (gameOverManager.isGameOver && Input.GetMouseButtonDown(0))
        {
            print("restarting the game");
            SceneManager.LoadScene(0);
        }
    }
}
