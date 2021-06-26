using UnityEngine;

public class StartGameMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject inGameUI;

    public void OnPlayButtonClicked()
    {
        inGameUI.SetActive(true);
        gameObject.SetActive(false);
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
