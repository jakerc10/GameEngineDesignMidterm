using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
      if(other.collider.tag == "Bullet")
        {
            ScoreManager.instance.HitDisplay(1);
            // Destroy(gameObject);
            transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);

        }
    }
}
