using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
private float raceTime = 0;
private bool raceRunning;

private void Update()
{
    if (raceRunning)
    raceTime += Time.deltaTime;
}

private void RaceFlags()
{
    raceTime += 2;
    Debug.Log("Player received penalty");
}

private void OnEnable()
{
    GameEvents.RaceFlags += RaceFlags;
    GameEvents.RaceFinish += RaceFinish;
    GameEvents.RaceStart += StartRace;
}
private void OnDisable()
{
    GameEvents.RaceFlags -= RaceFlags;
    GameEvents.RaceFinish -= RaceFinish;
    GameEvents.RaceStart -= StartRace;
}
private void StartRace()
{
    raceTime = 0;
    raceRunning = true;
    Debug.Log("Race started");
}
private void RaceFinish()
{
    raceRunning = false;
    Debug.Log("Race Finished " + raceTime);
}
}
