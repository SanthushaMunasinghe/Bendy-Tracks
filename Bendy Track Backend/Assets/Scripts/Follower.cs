using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    [SerializeField] private PathCreator pathCreator;
    [SerializeField] private float followSpeed = 5;
    float distTraveled;

    void Start()
    {
        
    }

    void Update()
    {
        distTraveled += followSpeed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distTraveled, EndOfPathInstruction.Reverse);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distTraveled);
    }
}
