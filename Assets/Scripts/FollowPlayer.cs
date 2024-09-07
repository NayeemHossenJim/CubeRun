using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Camera;
    public Vector3 offset;
    void Update()
    {
        transform.position = Camera.position  + offset;
    }
}
