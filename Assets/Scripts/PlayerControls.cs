using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private GameObject tennisBatBlue;
    private GameObject ball;
    private List<Vector3> velocities;
    private int velocityArraySize = 10;
    void Start()
    {
        velocities = new List<Vector3>();
        tennisBatBlue = GameObject.Find("TennisBatBlue");
        ball = GameObject.Find("Ball");
        GameState.playerStartingPosition = Camera.main.transform.position + Constants.BAT_OFFSET;
        GameState.playerPosition = GameState.playerStartingPosition;
    }
    void Update()
    {
        float deltaX = GameState.playerPosition.x - GameState.playerStartingPosition.x;
        Vector3 newPosition = Camera.main.transform.position + Constants.BAT_OFFSET;
        Vector3 velocity = (newPosition - GameState.playerPosition) / Time.deltaTime;
        velocities.Insert(0, velocity);
        if (velocities.Count > velocityArraySize) velocities.RemoveAt(velocityArraySize);
        Vector3 avgVelocity = new Vector3(0,0,0);
        for (int i = 0; i < velocities.Count; i++) {
            avgVelocity += velocities[i] / velocities.Count;
        }
        GameState.playerSmoothVelocity = avgVelocity;
        GameState.playerVelocity = velocity;
        GameState.playerPosition = newPosition;
        transform.position = GameState.playerPosition;
        /* Quaternion ballQuat =  Quaternion.LookRotation(
            ball.transform.position - GameState.playerPosition - 2.0f * Vector3.forward,
            Vector3.up
        );*/
        Quaternion targetQuat = Quaternion.LookRotation(
            GameState.mouseTarget - GameState.playerPosition,
            Vector3.up
        );
        //tennisBatBlue.transform.rotation = ballQuat;
        tennisBatBlue.transform.rotation = targetQuat;
        GameState.playerRotation = tennisBatBlue.transform.eulerAngles;
        GameState.playerRotation.x = 270 - Math.Min(0,GameState.playerSmoothVelocity.z) * 2.0f;
        //GameState.playerRotation.x = 270 + GameState.swingPower * 10.0f;
        GameState.playerRotation.y += 180;
        tennisBatBlue.transform.eulerAngles = GameState.playerRotation;
    }
}