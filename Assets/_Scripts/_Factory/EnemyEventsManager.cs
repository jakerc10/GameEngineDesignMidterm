using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class EnemyEventsManager
{

    public static EnemyEventsManager instance;
    public abstract Color EnemyEditorColor();

    void Awake()
    {
        if (instance != null)
        {
            instance = this;
        }
    }
}



public class RedMat : EnemyEventsManager
{
    public override Color EnemyEditorColor()
    {
        return Color.red;
    }
}
