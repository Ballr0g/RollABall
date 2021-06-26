using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameMenu;

    public void OnContinueButtonClicked()
    {
        Time.timeScale = 1.0f;
        gameMenu.SetActive(true);
        gameObject.SetActive(false);
    }
    public void OnExitButtonClicked()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
