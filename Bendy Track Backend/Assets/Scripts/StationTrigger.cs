using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationTrigger : MonoBehaviour
{
    [SerializeField] private GameplayManager gameplayManager;

    private void OnTriggerEnter(Collider tramCol)
    {
        if (tramCol.tag == "Tram")
        {
            tramCol.gameObject.GetComponent<Follower>().isInStation = true;
            tramCol.gameObject.GetComponent<Follower>().distTraveled = 0;

            if (gameplayManager.resetCount != 0)
                gameplayManager.resetCount--;
        }
    }

    private void OnTriggerExit(Collider tramCol)
    {
        if (tramCol.tag == "Tram")
            tramCol.gameObject.GetComponent<Follower>().isInStation = false;
    }
}
