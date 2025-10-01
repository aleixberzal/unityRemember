using UnityEngine;
using UnityEngine.InputSystem;

public class pivotController : MonoBehaviour
{
    public float rotation_speed;

    public InputActionReference look_action;
    private Vector2 look_input;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        look_action.action.Enable();
    }

    void Update()
    {
        pivotRotation();
    }

    void pivotRotation()
    {

        look_input = look_action.action.ReadValue<Vector2>();
        float x_axis = look_input.x * rotation_speed * Time.deltaTime;

        transform.Rotate(0f, x_axis, 0f);
    }
}
