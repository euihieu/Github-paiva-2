using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{

    public int MaxHealth;
    public int PlayerHealth;
    public string HealthReducerTag;
    public string HealthAdderTag;
    public TMP_Text HealthText;

    // Enum on esimerkkinä, palataan myöhemmin
    public enum Tags
    {
        enemy,
        collectable,
        Joopajoo,
        EnemyUkkeli
    }
    public Tags tagSelected;
    void Start()
    {
        PlayerHealth = MaxHealth;
        UpdateHealthUI();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(HealthAdderTag)) // Kerätään healthiobjecti
        {
            if (PlayerHealth < MaxHealth) // Lisää Healthia vain näillä ehdoin, pienempi tai yhtäsuuri kuin MaxHealth
            {
                PlayerHealth += 1;
                UpdateHealthUI();
            }
        }
        else if (collision.CompareTag(tagSelected.ToString())) // Osutaan vihulaiseen tai myrkkysieneen
        {
            if (PlayerHealth >= 0)
            {
                PlayerHealth -= 1;
                UpdateHealthUI();

                

            }
            else {
                Debug.Log("Game over");
                // Nyt ladattaisiin Scene "Game Over". Lisää se Buildiin, muuten ei lataudu.
                SceneManager.LoadScene("GameOver");
            }

        }
    }



    private void UpdateHealthUI()
    {
        if (HealthText != null)
        {
            HealthText.text = "Health: " + PlayerHealth;

        }
        else
        {
            Debug.LogError("HealthText does not exist for crying out loud!");
        }
    }
}
