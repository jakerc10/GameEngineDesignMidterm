using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    int hits = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    public void HitDisplay(int killValue)
    {
        hits += killValue;
        Debug.Log("HITS:  " + hits);
    }
}
