using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
{
    GameEvents.CallRaceStart();
}
}
