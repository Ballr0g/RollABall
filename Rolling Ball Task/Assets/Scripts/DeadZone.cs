using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField]
    private DuringGameMenu inGameMenu;
    [SerializeField]
    private GameOverMenu gameOverMenu;
    [SerializeField]
    private GameObject playerBall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != playerBall)
        {
            return;
        }
        Destroy(other.gameObject);
        int finalScore = inGameMenu.playerScore;
        inGameMenu.gameObject.SetActive(false);
        gameOverMenu.gameObject.SetActive(true);
        gameOverMenu.SetFinalScoreText(finalScore);
    }
}
