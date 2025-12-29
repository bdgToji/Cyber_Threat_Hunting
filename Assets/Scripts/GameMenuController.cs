using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuController : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private InputActionReference openGameMenuAction;

    private void Awake()
    {
        openGameMenuAction.action.Enable();
        openGameMenuAction.action.performed += ToggleMenu;
    }

    private void OnDestroy()
    {
        openGameMenuAction.action.Disable();
        openGameMenuAction.action.performed -= ToggleMenu;
    }

    private void ToggleMenu(InputAction.CallbackContext context)
    {
        menu.SetActive(!menu.activeSelf);
    }
}
