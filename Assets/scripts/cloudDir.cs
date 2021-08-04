using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudDir : MonoBehaviour
{
    public float dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = new Vector2(dir, 0);
        transform.Translate(position * Time.deltaTime, 0);
        Destroy(gameObject, 10);
    }
}
