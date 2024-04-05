﻿using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f; 
    public float healthDecayRate = 0.5f; 
    private float currentHealth; 
    public TextMeshProUGUI healthText; 
    public Image healthBar;
    public GameObject Panel;
    public GameObject endLevelPanel;

    void Start()
    {
        currentHealth = maxHealth; 
    }

    void Update()
    {
        float deltaTime = Time.deltaTime;

        currentHealth -= healthDecayRate * deltaTime;

        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

        UpdateUI();

        if (currentHealth <= 0f)
        {
            GameOver();
            Debug.Log("Player died!");

        }
    }
    
    
    public void GameOver()
    {
        Panel.SetActive(true);
    }

    public void ShowEndPanel()
    {
        // Hier wird das End-Panel aktiviert
        endLevelPanel.SetActive(true);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
    }

    public void Heal(float amount)
    {
        currentHealth += amount;

        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
    }

    void UpdateUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + Mathf.RoundToInt(currentHealth); 
        }

        if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth; 
        }
    }
}