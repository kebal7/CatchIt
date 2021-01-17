using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Canvas gameOverCanvas;

    [SerializeField]
    private PlayerLife _playerLife;

    
    void Start()
    {
        Time.timeScale = 1f;
        gameOverCanvas.enabled = false;

        _playerLife.lifeLeft = 3;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverCanvas.enabled = true;

    }

    public void Restart()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
    }


}
