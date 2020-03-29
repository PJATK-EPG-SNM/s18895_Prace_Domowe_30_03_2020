using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public Transform gridPoseYStart, gridPoseYFinish;
    public float speed=13f;
    public Transform startPose;
    Vector3 nextPose;

    void Start()
    {
        nextPose = startPose.position;
    }

    void Update()
    {
        if (transform.position == gridPoseYStart.position)
        {
            nextPose = gridPoseYFinish.position;
        }
        if (transform.position == gridPoseYFinish.position)
        {
            nextPose = gridPoseYFinish.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPose, speed * Time.deltaTime);
    }
}
