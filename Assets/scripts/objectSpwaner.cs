using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpwaner : MonoBehaviour
{
    public Transform spwanPoint;
    public Transform cloudSpwanPoint;
    public float cloudstartTimeBeetweenSpawn;
    private float cloudtimebeetWeenSpwan;
    public GameObject[] cloud;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (cloudtimebeetWeenSpwan <= 0)
        {
            int rand = Random.Range(0, cloud.Length);
           
            Instantiate(cloud[rand], cloudSpwanPoint.position, Quaternion.identity);
            cloudtimebeetWeenSpwan = cloudstartTimeBeetweenSpawn;
        }
        else
        {
            cloudtimebeetWeenSpwan -= Time.deltaTime;
        }


    }
}
