using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coins;

    private GameplayManager gameplayManager;

    void Awake()
    {
        gameplayManager = GetComponent<GameplayManager>();
    }

    void Update()
    {
        coins.text = "Coins: " + gameplayManager.currentCoins.ToString();
    }
}
