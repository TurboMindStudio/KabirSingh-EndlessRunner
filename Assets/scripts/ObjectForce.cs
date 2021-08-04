using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForce : MonoBehaviour
{
    private Vector2 direction;
    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(-speed, 0);
        transform.Translate(direction*Time.deltaTime, 0);
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Destroy(gameObject);
        }
    }
}
