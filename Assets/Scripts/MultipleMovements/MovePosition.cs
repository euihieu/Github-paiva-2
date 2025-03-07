using UnityEngine;

public class MovePosition : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public Transform playerPosition;
    public float enemyMoveSpeed;
   Vector2 newPosition;
    private float moveSpeed;

    private void Update()
    {
        // Calculoi uusi positio enemylle
        newPosition = Vector2.MoveTowards(rb.position, playerPosition.position,
            moveSpeed * Time.deltaTime);
        // Move to new position:
        rb.MovePosition(playerPosition.position);
    }
}
