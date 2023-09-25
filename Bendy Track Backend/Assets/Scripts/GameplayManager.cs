using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameObject[] tramList;

    public int resetCount = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetResetCount()
    {
        if (resetCount == 0)
            resetCount = tramList.Length;
    }
}
