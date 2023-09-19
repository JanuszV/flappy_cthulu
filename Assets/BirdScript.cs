using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool Alive = true;
    public GameObject splash;
    public GameObject bubel;
    public SpriteRenderer spriteRenderer;
    public Sprite dead;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && Alive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            splash.GetComponent<AudioSource>().Play();
            for (int i = 0; i < UnityEngine.Random.Range(1, 10); i++)
            {
                Instantiate(bubel, new Vector3(myRigidbody.position.x, myRigidbody.position.y, transform.rotation.z - 3), transform.rotation);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && !Alive)
        {
            logic.restartGame();
        }
    }
    private void OnBecameInvisible()
    {
       
        logic.gameOver();
        Alive = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        Alive = false;
        spriteRenderer.sprite = dead;
    }
}
