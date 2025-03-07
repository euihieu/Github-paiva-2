using UnityEngine;

public class GameobjectTranslate : MonoBehaviour
{
    [Header("Checkaa gameobjectin vauhti t�st�")]
    public float moveHorizontal;
    public float moveVertical;
    Vector3 movement;
    [Tooltip("Pid� arvo yli nollan, ei liiku muutan")]
    public float movementSpeed;



    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, moveVertical);
        transform.Translate(movementSpeed * Time.deltaTime * movement);

        // Laitetaan uuteen GameObjectiin nimelt� "Translate"
    }
}
