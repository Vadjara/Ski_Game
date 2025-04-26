using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBords : MonoBehaviour
{
    [SerializeField] private List<float> results = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        results.Clear();
        for (int i = 0; i < 5; i++)
        {
            float toAdd = PlayerPrefs.GetFloat("time" + i, 999999);
            results.Add(toAdd);
        }
    }
    public void AddResult(float time)
    {
        results.Add(time);
        results.Sort();
        for (int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetFloat("time" + i, results[i]);
        }
        PlayerPrefs.Save();
    }

}
