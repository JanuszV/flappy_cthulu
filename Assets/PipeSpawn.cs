using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawn : MonoBehaviour
{
    public GameObject spawn;
    public GameObject spawn2;
    public float spawnRate = 2;
    private float timer = 0, timer2 = 0;
    public float heighOffset = 1;
 
    // Start is called before the first frame update
    void Start()
    {
            spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heighOffset;
        float highestPoint = transform.position.y + heighOffset;
        Instantiate(spawn, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }
}
