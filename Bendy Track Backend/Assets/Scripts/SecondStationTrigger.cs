using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondStationTrigger : MonoBehaviour
{
    [SerializeField] private GameplayManager gameplayManager;

    private void OnTriggerEnter(Collider tramCol)
    {
        if (tramCol.tag == "Tram")
        {
            tramCol.gameObject.GetComponent<Follower>().isHalfway = true;
        }
    }
}
