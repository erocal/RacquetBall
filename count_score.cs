using HTC.UnityPlugin.Vive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_score : MonoBehaviour
{
    public int score;

    [SerializeField] private GameObject Ball;
    [SerializeField] private int ballAmount;
    [SerializeField] private GameObject particle;

    [SerializeField] private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        print(score);
        if(timer < 0)
        { 
            for(int i = 0; i < ballAmount; i++)
            {
                GameObject newBall = Instantiate(Ball);
                newBall.transform.position = this.transform.position;
                Destroy(newBall, 10);
            }
            timer = 5;
            
        }

        Instantiate(particle);
    }
}
