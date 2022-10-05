using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySubject
{
    List<Observer> observers = new List<Observer>();

    public void OnNotify()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify();
        }
    }

    public void AddEObserver(Observer observer)
    {
        observers.Add(observer);
    }
}
