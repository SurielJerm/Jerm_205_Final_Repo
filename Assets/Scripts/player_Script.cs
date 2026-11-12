using UnityEngine;
using UnityEngine.InputSystem;

public class player_Script : MonoBehaviour
{
    InputAction moveAction;
    InputAction sprintInput;
    InputAction lookAction;
    InputAction cursorAction;
    Rigidbody playerBody;
    Camera mainCamera;

    public float moveSpeed = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        sprintInput = InputSystem.actions.FindAction("Sprint");
        playerBody = GetComponent<Rigidbody>();

        mainCamera = GetComponentInChildren<Camera>();
        lookAction = InputSystem.actions.FindAction("Look");
        cursorAction = InputSystem.actions.FindAction("Point");
    }

    void FixedUpdate()
    {
        //Player Movement
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveInput.x, 0f, moveInput.y);
        playerBody.MovePosition(transform.position + move * moveSpeed * Time.deltaTime);

    }

    void Update()
    {
        Vector2 lookInput = lookAction.ReadValue<Vector2>();

    }
}
