using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform PlayerTransform;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position - PlayerTransform.position;
    }

    private void FixedUpdate()
    {
        transform.position = PlayerTransform.position + offset;
    }
}
