using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI finalScoreText;

    public void SetFinalScoreText(int finalScore)
    {
        finalScoreText.SetText($"Total score: {finalScore}");
    }

    public void OnRestartButtonClicked()
    {
        if (Physics.gravity.y > 0)
        {
            Physics.gravity *= -1.0f;
        }
        SceneManager.LoadScene(0);
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
