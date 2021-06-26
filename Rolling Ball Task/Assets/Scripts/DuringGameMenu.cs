using UnityEngine;
using TMPro;

public class DuringGameMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject playerBody;
    [SerializeField]
    private GameObject pauseMenuCanvas;
    [SerializeField]
    private TextMeshProUGUI playerScoreText;
    [SerializeField]
    private PlatformsMovement platformsBase;

    public int playerScore;
    void Start()
    {
        playerScore = 0;
        playerScoreText.SetText($"Score: {playerScore}");
    }

    void OnEnable()
    {
        if (playerBody != null)
        {
            playerBody.SetActive(true);
        }
        platformsBase.SetMovementActive(true);
    }

    void OnDisable()
    {
        if (playerBody != null)
        {
            playerBody.SetActive(false);
        }
        platformsBase.SetMovementActive(false);
    }

    public void OnPauseButtonClicked()
    {
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        gameObject.SetActive(false);
    }

    public void AddPlayerScore(int addedPoints)
    {
        playerScore += addedPoints;
        playerScoreText.SetText($"Score: {playerScore}");
    }
}
