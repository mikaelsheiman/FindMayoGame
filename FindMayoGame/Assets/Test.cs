using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private Rigidbody rb;
    private MeshRenderer mr;
    private Material material;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        mr = gameObject.GetComponent<MeshRenderer>();
        material = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = material.color;
        color.b += 0.01f * Time.deltaTime;
        material.color = color;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * 10;
        }
    }

    private void FixedUpdate()
    {
        
    }
}
