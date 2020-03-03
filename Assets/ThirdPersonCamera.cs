using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    public float distanceAway = 20f;
    public float distanceUp = 20f;
    public float smooth = 2f;               // how smooth the camera movement is

    private Vector3 m_TargetPosition;       // the position the camera is trying to be in)

    Transform follow;        //the position of Player

    void Start()
    {
        follow = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {
        // setting the target position to be the correct offset from the 
        m_TargetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;

        // making a smooth transition between it's current position and the position it wants to be in
        transform.position = Vector3.Lerp(transform.position, m_TargetPosition, Time.deltaTime * smooth);

        // make sure the camera is looking the right way!
        transform.LookAt(follow);
    }
}