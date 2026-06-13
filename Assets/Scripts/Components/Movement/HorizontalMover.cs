using UnityEngine;

/// <summary>
/// Moves transform horizontally based on keyboard input (A/D or Arrow keys).
/// </summary>
public class HorizontalMover : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float speed = 5f;
    
    [Header("Optional")]
    [SerializeField] private bool flipSprite = true;
    
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D playerRb;
    
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerRb = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        playerRb.linearVelocity = new Vector2(
            horizontal * speed,
            playerRb.linearVelocity.y
        );

        if (flipSprite && spriteRenderer != null && horizontal != 0)
        {
            spriteRenderer.flipX = horizontal < 0;
        }
    }
}
