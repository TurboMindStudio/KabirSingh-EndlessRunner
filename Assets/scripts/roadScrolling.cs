using UnityEngine;

public class roadScrolling : MonoBehaviour
{
    public float xVel;
    Vector2 offset;
    private Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(xVel, 0);
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
