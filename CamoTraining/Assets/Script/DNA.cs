using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    //gene for colour
    public float r;
    public float g;
    public float b;

    float x;
    public float y;
    float z = 1;

    bool dead = false;
    public float timeToDie = 0;

    SpriteRenderer sRenderer;
    Collider2D sCollider2D;
    Transform transform;
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider2D = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
        transform = GetComponent<Transform>();
        x = y;
        transform.transform.localScale = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        dead = true;
        timeToDie = populationManager.elapsed;
        Debug.Log("Dead At: " + timeToDie);
        sRenderer.enabled = false;
        sCollider2D.enabled = false;
    }
}
