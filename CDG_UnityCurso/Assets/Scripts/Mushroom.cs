using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;
    public int Score;

    void Start()
    {

        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            Game_Score.instance.totalScore += Score;
            Game_Score.instance.UpdateScoreText();

            Destroy(gameObject, 0.25f);
        }
    }

}
