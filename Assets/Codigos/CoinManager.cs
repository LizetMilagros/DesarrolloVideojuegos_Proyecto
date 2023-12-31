using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public TMP_Text coinText;

    private int coins = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateCoinText();
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = coins.ToString();
        }
    }

    public void Update(){
         if (coins == 10 && SceneManager.GetActiveScene().buildIndex == 1)
        {
            // Carga la escena de "MinijuegoNivel" si se cumplen las condiciones.
            SceneManager.LoadScene("MinijuegoNivel", LoadSceneMode.Single);
        }
        if (coins == 15 && SceneManager.GetActiveScene().buildIndex == 4)
        {
            SceneManager.LoadScene("TercerNivel", LoadSceneMode.Single);
        }
        if (coins == 17 && SceneManager.GetActiveScene().buildIndex == 5)
        {
            SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
        }
    }
}
