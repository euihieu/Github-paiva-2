using UnityEngine;

public class ItemCollect : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("collectable"))
        {
            Debug.Log("Collected an item");
            collision.transform.parent.gameObject.SetActive(false);
            // collision.gameObject.SetActive(false);

        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //}
}
