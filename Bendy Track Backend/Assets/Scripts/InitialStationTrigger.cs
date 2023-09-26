using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialStationTrigger : MonoBehaviour
{
    [SerializeField] private GameplayManager gameplayManager;

    private void OnTriggerEnter(Collider tramCol)
    {
        if (tramCol.tag == "Tram")
        {
            Follower follower = tramCol.gameObject.GetComponent<Follower>();
            follower.isInStation = true;
            follower.distTraveled = 0;
            gameplayManager.initialCount++;

            if (gameplayManager.resetCount != 0)
                gameplayManager.resetCount--;

            if (follower.isHalfway)
                gameplayManager.GenerateCoins();

            follower.isHalfway = false;
        }
    }

    private void OnTriggerExit(Collider tramCol)
    {
        if (tramCol.tag == "Tram")
        {
            tramCol.gameObject.GetComponent<Follower>().isInStation = false;
        }
    }
}
