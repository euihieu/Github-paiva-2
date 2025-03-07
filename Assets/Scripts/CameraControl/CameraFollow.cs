using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 targetPosition;
    public float followDelay;
    public float minYposition;
    public float initialYposition;

    // Viitataan t‰ss‰ suoraan Namespace TMPro
    //  TMPro.TextMeshPro jotainTextUI;
    //  Tai kirjoitat ylˆs "using TMPro;" jolloin voit k‰ytt‰‰ sen ominaisuuksia
    //  TextMeshPro jotainTextUI;  

    private void Start()
    {
        if (playerPosition == null)
        {
            Debug.LogError("PlayerPosition not assigned");
        }

        // Tallennetaan t‰m‰n GameObjectin eli Cameran y-positio heti alussa
        initialYposition = transform.position.y;
    }

    private void LateUpdate() // Calculoidaan Updaten j‰lkeen
    {
        // Tarkistetaan, onko playerPosition m‰‰ritetty
        if (playerPosition == null)
        {
            return; // Palautetaan tyhj‰ arvo, jos playerPosition on tyhj‰
        }

        // M‰‰ritet‰‰n targetPosition pelaajan x- ja y-koordinaattien mukaan
        // ja erikseen kameran z-koordinaatin mukaan
        targetPosition = new Vector3(playerPosition.position.x,
            playerPosition.position.y, transform.position.z);

        // Estet‰‰n kameran y-koordinaattia menem‰st‰ minYposition alapuolelle
        if (targetPosition.y < minYposition)
        {
            targetPosition.y = minYposition; // Pakotetaan Camera palautumaan minYposition:in tasolle
        }

        // Siirret‰‰n kameraa kohti targetPositionia k‰ytt‰en Lerp-funktiota
        // Lerp (Lineaarinen interpolointi) tasoittaa liikett‰. Liike tapahtuu 0-1 arvon v‰lill‰ eli
        // followDelay on oltava 0-1 v‰lill‰. T‰ss‰ kerrotaan se viel‰ fixed Delta Timella niin saadaan smoothi liike 
        transform.position = Vector3.Lerp(transform.position, targetPosition,
            followDelay * Time.fixedDeltaTime);
    }
}

