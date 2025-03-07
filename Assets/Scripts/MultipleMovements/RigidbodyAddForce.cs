

using UnityEngine;
// Vaatii tietyn komponentin ja luo sen, jos sit� ei ole.
// Componenttia ei voi poistaa niin kauan kuin t�m� on scriptiss�
//[RequireComponent(typeof(Rigidbody2D))]
public class RigidbodyAddForce : MonoBehaviour
{

    [Header("Checkaa gameobjectin vauhti t�st�")]
    public float moveHorizontal;
    public float moveVertical;
    public float jumpForce;

    Vector3 movement;
    [Tooltip("Pid� arvo yli nollan, ei liiku muutan")]
    public float movementSpeed;

    Rigidbody2D rb;

    private void Start()
    {
        // Varmistetaan, ett� on Rigidbody2D componentti
        if (rb != null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        else
        {
            rb = gameObject.AddComponent<Rigidbody2D>();

        }

    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
       // moveVertical = Input.GetAxis("Vertical");
       

        movement = new Vector3(moveHorizontal, moveVertical);
        rb.AddForce(movementSpeed * Time.deltaTime * movement, ForceMode2D.Impulse);
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        

        // Laitetaan uuteen GameObjectiin nimelt� "AddForce"
    }
}
