using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator playerAnimator;

    public PlayerAIInteractions playerAIInteractions;
    
    public PlayerMovement playerMovement;

    public GameObject ui_window;

    public PlayerRenderer playerRenderer;
    
    private Vector2 movementVector;


    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerRenderer = GetComponent<PlayerRenderer>();
        playerAIInteractions = GetComponent<PlayerAIInteractions>();
    }
    private void Update()
    {
        movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movementVector.Normalize();
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            playerAIInteractions.Interact(playerRenderer.IsSpriteFlipped);
        }
    }

    private void FixedUpdate()
    {
        MovePlayer(movementVector);
        if (movementVector.magnitude > 0)
        {
            ui_window.SetActive(false);
        }
        else
        {
            playerAnimator.SetBool("Walk", false);
        }
    }

    

    private void MovePlayer(Vector2 movementVector)
    {
        playerAnimator.SetBool("Walk", true);
        playerMovement.MovePlayer(movementVector);
        playerRenderer.RenderPlayer(movementVector);
    }

    public void ReceiveDamaged()
    {
        playerRenderer.FlashRed();
    }
    
}
