using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyObserver
{
    public abstract void OnNotify();
}

public class Enemies : EnemyObserver
{
    GameObject enemyObj;
    EnemyEventsManager enemyEvent;

    public Enemies(GameObject enemyObj, EnemyEventsManager enemyEvent)
    {
        this.enemyObj = enemyObj;
        this.enemyEvent = enemyEvent;
    }

    public override void OnNotify()
    {
        EnemyColor(enemyEvent.EnemyEditorColor());
    }

    void EnemyColor(Color mat)
    {
        if (enemyObj)
        {
            enemyObj.GetComponent<Renderer>().materials[0].color = mat;
        }
    }
}