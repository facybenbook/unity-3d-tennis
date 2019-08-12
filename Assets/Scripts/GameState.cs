using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState
{
    public static int turn = 0; // 0=player, 1=opponent
    public static int bounces = 0;
    public static int lastRoundWinner = 0; // 0=player, 1=opponent
    public static int playerScore = 0;
    public static int opponentScore = 0;
    public static int currentRound = 0;
    public static float cameraJumpVelocity = 0;
    public static float swingPower = 0.0f;
    public static bool cameraJumping = false;
    public static bool gamePaused = true;
    public static Vector3 cameraStartingPosition = new Vector3(0,0,0);
    public static Vector3 cameraPosition = new Vector3(0,0,0);
    public static Vector3 ballVelocity = Constants.BALL_INITIAL_VELOCITY;
    public static Vector3 ballPosition = new Vector3(0,0,0);
    public static Vector3 ballStartingPosition = new Vector3(0,0,0);
    public static Vector3 playerVelocity = new Vector3(0,0,0);
    public static Vector3 playerSmoothVelocity = new Vector3(0,0,0);
    public static Vector3 playerPosition = new Vector3(0,0,0);
    public static Vector3 playerStartingPosition = new Vector3(0,0,0);
    public static Vector3 playerRotation = new Vector3(270,90,-90);
    public static Vector3 mouseTarget = new Vector3(0,0,0);
    public static Vector3 opponentPosition = new Vector3(0,0,0);
    public static Vector3 opponentStartingPosition = new Vector3(0,0,0);
    public static void resetRound() {
        turn = 0;
        bounces = 0;
        // playerScore = 0;
        // opponentScore = 0;
        // currentRound = 0;
        cameraPosition = cameraStartingPosition;
        ballVelocity = Constants.BALL_INITIAL_VELOCITY;
        ballPosition = ballStartingPosition;
        playerVelocity = new Vector3(0,0,0);
        playerPosition = playerStartingPosition;
        playerRotation = new Vector3(270,90,-90);
        opponentPosition = opponentStartingPosition;
    }
    public static void resetGame() {
        turn = 0;
        bounces = 0;
        lastRoundWinner = 0;
        playerScore = 0;
        opponentScore = 0;
        currentRound = 0;
        cameraPosition = cameraStartingPosition;
        ballVelocity = Constants.BALL_INITIAL_VELOCITY;
        ballPosition = ballStartingPosition;
        playerVelocity = new Vector3(0,0,0);
        playerPosition = playerStartingPosition;
        playerRotation = new Vector3(270,90,-90);
        opponentPosition = opponentStartingPosition;
    }
}