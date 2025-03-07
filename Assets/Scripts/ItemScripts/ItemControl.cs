using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        else
        {
            Debug.LogWarning("Puuttuu spraitrendereri!");
            // Luo automaattisesti jokin Componentti
           // gameObject.AddComponent<SpriteRenderer>();  
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if(collision.CompareTag("Player"))
            {
                Debug.Log("Found an item!");
                spriteRenderer.color = Color.black;
               //collision.gameObject.SetActive(false);  
                
            }
        }
    }
}
