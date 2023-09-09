using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerAIInteractions _playerAIInteractions;
    private PlayerMovement _playerMovement;
    private IMovementInput _movementInput;
    private PlayerAnimations _playerAnimations;
    private PlayerRenderer _playerRenderer;
    public UIController uiController;
    
    private void Start()
    {
        _playerAnimations = GetComponent<PlayerAnimations>();
        _playerMovement = GetComponent<PlayerMovement>();
        _playerRenderer = GetComponent<PlayerRenderer>();
        _playerAIInteractions = GetComponent<PlayerAIInteractions>();
        _movementInput = GetComponent<IMovementInput>();
        _movementInput.OnInteractEvent += () => _playerAIInteractions.Interact(_playerRenderer.IsSpriteFlipped);
    }

    private void FixedUpdate()
    {
        _playerMovement.MovePlayer(_movementInput.MovementInputVector);
        _playerRenderer.RenderPlayer(_movementInput.MovementInputVector);
        _playerAnimations.SetupAnimations(_movementInput.MovementInputVector);
        if (_movementInput.MovementInputVector.magnitude > 0)
        {
            uiController.ToggleUI(false);
        }
    }

    public void ReceiveDamaged()
    {
        _playerRenderer.FlashRed();
    }
    
}
