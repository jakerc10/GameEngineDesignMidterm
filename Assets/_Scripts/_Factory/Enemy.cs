using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    private EnemyFactory factory;
    public abstract string Name { get; }

    public abstract GameObject Create(GameObject prefab);

  
    /////////////////////////Collide With Player//////////////////////////////
    private void OnCollisionEnter(Collision other)
    {
        
        if (other.collider.tag == "Player")
        {
            Debug.Log("hello");
           // factory.GetEnemy("Zombie").roate;

        }
    }
    /////////////////////////////////////////////////////////////
}

public class Zombie : Enemy
{
    public override string Name => "Zombie";
    // public override string Name { get { return "Zombie"} }

    public override GameObject Create(GameObject prefab)
    {
    GameObject enemy = Instantiate(prefab);
        Debug.Log("Zombie enemy is created");
        return enemy;
    }
}

public class Crab : Enemy
{
    public override string Name => "Crab";

    public override GameObject Create(GameObject prefab)
    {
        GameObject enemy = Instantiate(prefab);
        Debug.Log("Crab enemy is created");
        return enemy;
    }
}


