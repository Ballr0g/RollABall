using UnityEngine;

public class PointsBarrier : MonoBehaviour
{
    [SerializeField]
    private DuringGameMenu inGameMenu;
    [SerializeField]
    private GameObject playerBall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != playerBall)
        {
            return;
        }
        inGameMenu.AddPlayerScore(1);
        Destroy(gameObject);
    }
}
