
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int PlayerHealth;
    public int MaxHealth;
    public string HealthReducerTag;
    public string HealthAdderTag;
    public TMP_Text HealthText;

    void Start()
    {
        PlayerHealth = MaxHealth;
        UpdateHealthUI();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(HealthReducerTag))
        {
            PlayerHealth = Mathf.Max(PlayerHealth - 1, 0);
            UpdateHealthUI();
            if (PlayerHealth == 0)
            {
                Debug.Log("Player health is zero!");
            }
        }
        else if (other.CompareTag(HealthAdderTag))
        {
            PlayerHealth = Mathf.Min(PlayerHealth + 1, MaxHealth);
            UpdateHealthUI();
        }
    }

    void UpdateHealthUI()
    {
        if (HealthText != null)
        {
            HealthText.text = "Health: " + PlayerHealth;
        }
    }
}
