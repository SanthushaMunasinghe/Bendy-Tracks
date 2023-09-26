using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    [SerializeField] private PathCreator pathCreator;
    [SerializeField] private GameplayManager gameplayManager;

    [SerializeField] private float followSpeed = 5;

    public bool isInStation;
    public bool isHalfway;
    public float distTraveled;

    void Start()
    {
    }

    void Update()
    {
        if (gameplayManager.resetCount == 0 || !isInStation)
            FollowPath();
    }

    private void FollowPath()
    {
        distTraveled += followSpeed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distTraveled, EndOfPathInstruction.Reverse);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distTraveled, EndOfPathInstruction.Reverse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameplayManager.SetResetCount();
        followSpeed *= -1;
    }
}
