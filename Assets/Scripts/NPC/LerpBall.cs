using UnityEngine;

public class LerpBall : MonoBehaviour
{
    public Transform positionA;
    public Transform positionB;
    public float lerpValue; // Position A:n ja B:n välillä (skaalalla 0-1)
    public float lerpSpeed; // Vauhti, millä liikutaan A:sta B:hen (0:sta 1:seen)

    float LimitLerpValue()
    {
        if(lerpValue < 1)
        {
            lerpValue += lerpSpeed;
       
        }
        else
        {
            lerpValue = 1;
        }
        return lerpValue;

    }

    private void Update()
    { // Liikuta GameObject kohti valittua positiota tietyllä nopeudella
        //transform.position = Vector2.MoveTowards(transform.position, positionA.position, 0.1f);

        // Napsahtaa heti kiinni kohteeseen
        //transform.position = new Vector2(positionA.position.x, positionA.position.y);       

        // Lyhyempi tapa suoritaa LimitLerpValue-funktio: ?:
        //transform.position = Vector2.Lerp(positionA.position, 
        //    positionB.position, lerpValue < 1? lerpValue += lerpSpeed: 1);

        transform.position = Vector2.Lerp(positionA.position,
            positionB.position,LimitLerpValue() );

    }


}
