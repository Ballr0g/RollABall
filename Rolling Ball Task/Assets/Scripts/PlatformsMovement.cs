using UnityEngine;

public class PlatformsMovement : MonoBehaviour
{
    [SerializeField]
    private float platformMovementSpeed = 1.0f;
    private float currentMovementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentMovementSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // The camera is inversed, movement ended up kinda being reveresed as well, whoops.
        Vector3 smoothedTranslation = new Vector3(0f, 0f, -currentMovementSpeed) * Time.deltaTime;
        gameObject.transform.Translate(smoothedTranslation, Space.World);
    }

    public void SetMovementActive(bool isActive)
    {
        currentMovementSpeed = isActive ? platformMovementSpeed : 0;
    }
}
