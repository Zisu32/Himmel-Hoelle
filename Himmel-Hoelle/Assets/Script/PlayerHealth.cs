﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f; 
    public float healthDecayRate = 1f; 
    private float currentHealth; 
    public TextMeshProUGUI healthText; 
    public Image healthBar;
    public GameObject Panel;
    public GameObject endLevelPanel;
    public Image border;
    public Color defaultColor = Color.white;
    
    void Start()
    {
        currentHealth = maxHealth; 
        Image imageComponent = GetComponent<Image>(); // Get the Image component
        
        if (border != null)
        {
            border.color = defaultColor; // Set the border's color
        }
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
        }
    }
     
    public void GameOver()
    {
        endLevelPanel.SetActive(false);
        Panel.SetActive(true);
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        if (border != null)
        {
            border.color = Color.red; // Change the border's color to red when taking damage
            StartCoroutine(ResetBorderColor()); // Start coroutine to reset color
        }
        UpdateUI();
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        if (border != null)
        {
            border.color = Color.green; // Change the border's color to red when taking damage
            StartCoroutine(ResetBorderColor()); // Start coroutine to reset color
        }
        UpdateUI();
    }

    public void ShowEndPanel()
    {
        Panel.SetActive(false);
        endLevelPanel.SetActive(true);
    }

    void UpdateUI()
    {
        if (healthText != null)
        {
            healthText.text = "" + Mathf.RoundToInt(currentHealth); 
        }

        if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth; 
        }
    }
    IEnumerator ResetBorderColor()
    {
        yield return new WaitForSeconds(1); // Wait for 1 seconds
        if (border != null && currentHealth > 0) // Check if the player is still alive
        {
            border.color = defaultColor; // Reset the color to the default
        }
    }
}
