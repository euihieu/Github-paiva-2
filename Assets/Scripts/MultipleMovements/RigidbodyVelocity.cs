
using UnityEngine;



public class RigidbodyVelocity : MonoBehaviour
{
    [Header("Checkaa gameobjectin vauhti tästä")]
    public float moveHorizontal;
    public float moveVertical;
    Vector3 movement;
    [Tooltip("Pidä arvo yli nollan, ei liiku muutan")]
    public float movementSpeed;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        movement = new Vector2(moveHorizontal, moveVertical);
        rb.linearVelocity = new Vector3(movement.x, movement.y) * movementSpeed;

        // Flip the sprite based on the horizontal movement direction
        if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = false; // Facing right
        }
        else if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = true; // Facing left
        }

        // Laitetaan uuteen GameObjectiin nimeltä "Player"
    }
}
