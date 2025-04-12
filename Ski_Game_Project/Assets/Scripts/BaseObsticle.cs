using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObstacle : MonoBehaviour
{
    void OnCollisionEnter()
    {
        onHit();
    }

    internal virtual void onHit()
    {
        GameEvents.CallTakeDamage();
        Debug.Log("obstacle was hit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
