﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{
    public GameObject thirdTrialBITCH;
    public GameObject SpawnLocation;
    private bool alreadyspawned;
    // Start is called before the first frame update
    void Start()
    {
        alreadyspawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Bossfight") == null && alreadyspawned == false)
        {
            GameObject Trial3Finish = Instantiate(thirdTrialBITCH, SpawnLocation.transform.position, Quaternion.identity);
            Trial3Finish.name = "Trial3Finish";
            alreadyspawned = true;
        }
    }
}
