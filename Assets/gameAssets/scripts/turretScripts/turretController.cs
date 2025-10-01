using UnityEngine;
using UnityEngine.InputSystem;

public class turretController : MonoBehaviour
{
    public float rotation_speed;

    public InputActionReference look_action;
    public InputActionReference shoot_action;

    private Vector2 look_input;


    public GameObject projectile_prefab;
    public Transform fire_point;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        shoot_action.action.Enable();

        look_action.action.Enable();
    }

    void Update()
    {
        turretRotation();

        if (InputSystem.actions.FindAction("shoot").WasPressedThisFrame())
        {
           GameObject newProjectile = Instantiate(projectile_prefab, fire_point.position, fire_point.rotation);

            Destroy(newProjectile, 3); 
        }

    }

    void turretRotation()
    {
        if (look_action == null) return;

        look_input = look_action.action.ReadValue<Vector2>();
        float y_axis = -look_input.y * rotation_speed * Time.deltaTime;

        transform.Rotate(0f, 0f, y_axis);
    }
}
