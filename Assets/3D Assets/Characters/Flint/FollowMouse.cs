using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Mouse.current.position.ReadValue();
        pos.z = 4f;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
