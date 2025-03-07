using UnityEngine;

public class AnimationsControl : MonoBehaviour
{
    [SerializeField] Animator animator;

    // Referoidaan toista scriptiä
    [SerializeField] RigidbodyVelocity rbvelocity;
    public bool canRun;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.CompareTag("hill") )
    //    {
    // Ei tarvita, sillä Stay hoitaa myös Enterin ja Exitin

    //    }
    //}
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hill"))
        {
            if (rbvelocity.moveHorizontal != 0)
            {
                animator.SetBool("canRun", true);
                Debug.Log("Running up that hill!");
            }
            else
            {
                animator.SetBool("canRun", false);
                Debug.Log("On the hill but idle");
            }
        }
    }
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("hill"))
    //    {
    //        animator.SetBool("canRun", false);
    //        Debug.Log("Exittaa Collision-objectin tägillä hill");
    //    }

    //}

    // Käytetään tätä, jos kyseessä on jokin nopea triggeröinti, kuten itemin keräys tai vihollisen osuma. Muista "isTrigger" vain toiseen Game Objectiin
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.CompareTag("hill"))
    //    {
    //        Debug.Log("Running up that hill");
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if(collision.CompareTag("hill"))
    //    {
    //        Debug.Log("Run out of hills");
    //    }
    //}


    void Update()
    {
        // 2 keinoa:

        if(rbvelocity.moveHorizontal !=0)
        {
           // canRun = true;
    
        }
        else
        {
           // canRun = false;

        }
           // canRun = rbvelocity.moveHorizontal != 0;
    }
}
