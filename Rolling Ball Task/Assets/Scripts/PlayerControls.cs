using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControls : MonoBehaviour
{
    private Rigidbody attachedBody;
    // Start is called before the first frame update
    void Start()
    {
        attachedBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && 
            Mathf.Abs(attachedBody.velocity.y) < 0.00001)
        {
            Physics.gravity *= -1.0f;
        }
    }
}
