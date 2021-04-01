using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Checkpoint : MonoBehaviour
{
    private Mario mario;
    private int CurrentCheckpointIndex;

    // Use this for initialization
    void Start()
	{
        mario = FindObjectOfType<Mario>();
        ResetCheckpoints();
    }
    public void ResetCheckpoints()
    {
        CurrentCheckpointIndex = 0;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // update spawn pos if Player passes checkpoint
        if (mario.gameObject.transform.position.x >= transform.position.x)
        {
            CurrentCheckpointIndex = Mathf.Max(CurrentCheckpointIndex, gameObject.transform.GetSiblingIndex());
            mario.AddReward(0.01f * CurrentCheckpointIndex);
            gameObject.SetActive(false);
        }
    }
    }




