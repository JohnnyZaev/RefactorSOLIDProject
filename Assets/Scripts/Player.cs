using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerAIInteractions playerAIInteractions;
    public PlayerMovement playerMovement;
    public PlayerInput playerInput;
    public PlayerAnimations playerAnimations;
    public PlayerRenderer playerRenderer;
    public UIController uiController;
    
    private void Start()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
        playerMovement = GetComponent<PlayerMovement>();
        playerRenderer = GetComponent<PlayerRenderer>();
        playerAIInteractions = GetComponent<PlayerAIInteractions>();
        playerInput = GetComponent<PlayerInput>();
        playerInput.OnInteractEvent += () => playerAIInteractions.Interact(playerRenderer.IsSpriteFlipped);
    }

    private void FixedUpdate()
    {
        playerMovement.MovePlayer(playerInput.MovementInputVector);
        playerRenderer.RenderPlayer(playerInput.MovementInputVector);
        playerAnimations.SetupAnimations(playerInput.MovementInputVector);
        if (playerInput.MovementInputVector.magnitude > 0)
        {
            uiController.ToggleUI(false);
        }
    }

    public void ReceiveDamaged()
    {
        playerRenderer.FlashRed();
    }
    
}
