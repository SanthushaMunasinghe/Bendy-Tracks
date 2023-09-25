using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    [SerializeField] private PathCreator pathCreator;
    [SerializeField] private float followSpeed = 5;
    public float rayRange = 1.0f;
    public bool isHit = false;

    float distTraveled;

    void Start()
    {
        
    }

    void Update()
    {
        distTraveled += followSpeed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distTraveled, EndOfPathInstruction.Reverse);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distTraveled, EndOfPathInstruction.Reverse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        followSpeed *= -1;
    }
}
