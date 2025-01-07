using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class BackMove : MonoBehaviour
{
    public Renderer spriteRenderer;
    public float speed = -1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = spriteRenderer.material.mainTextureOffset;
        offset = offset + new Vector2(0, speed * Time.deltaTime);
        spriteRenderer.material.mainTextureOffset = offset;
    }
}
