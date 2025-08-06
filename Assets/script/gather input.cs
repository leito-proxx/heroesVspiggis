using UnityEngine;
using UnityEngine.InputSystem;

public class gatherinput : MonoBehaviour
{
    //declarando una variable privada de tipo Input Actions queeeeeeeeeeeeeeee quiera kikika o nononaaaaaaa o mesiuuuuu
    private InputSystem_Actions controls;
    [SerializeField] private float _valueX;
    public float ValueX { get => _valueX;}

    private void Awake()
    {
      controls= new InputSystem_Actions();  
    }

    private void OnEnable()
    {
        controls.Player.Enable();
        controls.Player.Move.performed += StartMove;
        controls.Player.Move.canceled += StopMove;
    }
    private void StartMove(InputAction.CallbackContext context)
    {
        _valueX = context.ReadValue<float>();
    }
    private void StopMove(InputAction.CallbackContext context)
    {
        _valueX = 0;
    }
    private void OnDisable()
    {
        controls.Player.Disable();
        controls.Player.Move.performed -= StartMove;
        controls.Player.Move.canceled -= StopMove;
    }
}