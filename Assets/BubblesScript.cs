using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesScript : MonoBehaviour
{
   
    public Rigidbody2D bubel;
    public float deadzonex = -11, deadzoney = 7;

    // Start is called before the first frame update
    void Start()
    {
        bubel.velocity += (Vector2.left * Random.Range(-5, 5));
        if (transform.position.x < deadzonex || transform.position.y > deadzoney)
        {
            Destroy(gameObject);
        }
    }


}
