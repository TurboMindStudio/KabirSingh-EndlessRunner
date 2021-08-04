using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpwaner : MonoBehaviour
{
    
    public float startTimeBeetWeenSpwan;
    float timeBeetWeenSpwan;
    public float baricatestartTimeBeetWeenSpwan;
    float baricatetimeBeetWeenSpwan;
    public Transform baricteSpwanPoint;
    public GameObject[] coinsPattern;
    public Transform coinSpwanPoint;
    public GameObject baricate;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBeetWeenSpwan <= 0)
        {
            int randObs = Random.Range(0, coinsPattern.Length);
            Instantiate(coinsPattern[randObs], coinSpwanPoint.position, Quaternion.identity);
            timeBeetWeenSpwan = startTimeBeetWeenSpwan;
        }
        else
        {
            timeBeetWeenSpwan -= Time.deltaTime;
        }

        if (baricatetimeBeetWeenSpwan <= 0)
        {
            Instantiate(baricate, baricteSpwanPoint.position, Quaternion.identity);
            baricatetimeBeetWeenSpwan = baricatestartTimeBeetWeenSpwan;
        }
        else
        {
            baricatetimeBeetWeenSpwan -= Time.deltaTime;
        }
    }
}
