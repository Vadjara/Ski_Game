using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip playerHurtSound;
    [SerializeField] private AudioClip playerMissedFlag;

private void OnEnable()
{
    GameEvents.TakeDamage += PlayHurtSound;
    GameEvents.RaceFlags += PlayRaceFlags;
}
private void OnDisable()
{
    GameEvents.TakeDamage -= PlayHurtSound;
    GameEvents.RaceFlags -= PlayRaceFlags;
}
private void PlayHurtSound()
{
    source.PlayOneShot(playerHurtSound);
}
private void PlayRaceFlags()
{
    source.PlayOneShot(playerMissedFlag);
}
}
