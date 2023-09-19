using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    
    public float deadzonex = -11, deadzoney = 7;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(transform.position.x + Random.Range(-3,-1), transform.position.y + Random.Range(-3,3), -5) * Time.deltaTime;
        if (transform.position.x < deadzonex || transform.position.y > deadzoney)
        {
            Destroy(gameObject);
        }

    }
   
}
