using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainscrolling : MonoBehaviour
{
    
    public float dir;
    public float startX;
    public float endX;

    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mountain();

        if (transform.position.x <= endX)
        {
            transform.position = new Vector3(startX,transform.position.y ,transform.position.z );
        }
    }

    public void mountain()
    {
        Vector2 position = new Vector2(dir, 0);
        transform.Translate(position * Time.deltaTime, 0);
    }
}
