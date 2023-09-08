using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerAIInteractions playerAIInteractions;
    public PlayerMovement playerMovement;
    public IMovementInput movementInput;
    public PlayerAnimations playerAnimations;
    public PlayerRenderer playerRenderer;
    public UIController uiController;
    
    private void Start()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
        playerMovement = GetComponent<PlayerMovement>();
        playerRenderer = GetComponent<PlayerRenderer>();
        playerAIInteractions = GetComponent<PlayerAIInteractions>();
        movementInput = GetComponent<IMovementInput>();
        movementInput.OnInteractEvent += () => playerAIInteractions.Interact(playerRenderer.IsSpriteFlipped);
    }

    private void FixedUpdate()
    {
        playerMovement.MovePlayer(movementInput.MovementInputVector);
        playerRenderer.RenderPlayer(movementInput.MovementInputVector);
        playerAnimations.SetupAnimations(movementInput.MovementInputVector);
        if (movementInput.MovementInputVector.magnitude > 0)
        {
            uiController.ToggleUI(false);
        }
    }

    public void ReceiveDamaged()
    {
        playerRenderer.FlashRed();
    }
    
}
