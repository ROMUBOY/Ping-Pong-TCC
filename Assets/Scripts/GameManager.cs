using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject leftGoal;

    public GameObject rightGoal;

    public void StartGame()
    {
        Instantiate(ball, Vector3.zero, Quaternion.identity);
    }

    public void RestartGame()
    {
        
        leftGoal.GetComponent<Goal>().Restart();
        rightGoal.GetComponent<Goal>().Restart();        

        StartGame();
    }
}
