using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFlags : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
{
    GameEvents.CallRaceFlags();
}
}
