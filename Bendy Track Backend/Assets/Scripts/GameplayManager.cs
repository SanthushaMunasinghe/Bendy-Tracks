using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameObject[] stationList;
   
    private int tramCount;
    public int resetCount = 0;

    public int currentCoins;
    public int ticketPrice;

    void Start()
    {
        SetCurrentCoins();
    }

    void Update()
    {
        
    }

    public void SetResetCount()
    {
        if (resetCount == 0)
            resetCount = tramCount;
    }

    public void SetCurrentCoins()
    {
        currentCoins = 300;
    }

    public void GenerateCoins()
    {
        currentCoins += ticketPrice;
    }

    public void UnlockStation(int value, int index, GameObject hitObj)
    {
        if (value <= currentCoins)
        {
            Destroy(hitObj);
            tramCount++;
            stationList[index].SetActive(true);
            currentCoins -= value;
        }
    }
}
