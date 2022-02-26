using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMotor : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Collider grabTrigger;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        grabTrigger = gameObject.GetComponent<SphereCollider>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GetMotionVector());
    }

    void FixedUpdate()
    {
        //transform.Translate(GetMotionVector());
        rb.velocity = GetMotionVector();
    }

    private void OnCollisionStay(Collision collision)
    {
        print(1);
        //Debug.Log(grabTrigger.attachedRigidbody == collision.rigidbody && collision.gameObject.CompareTag("MovableObject"));
        //if (Input.GetKey(KeyCode.Mouse0))
            if (collision.gameObject.CompareTag("MovableObject"))
            {
                print(1);
                collision.rigidbody.AddForce(GetMotionVector());
            }
    }

    private Vector3 GetMotionVector()
    {
        float ForwardAxis = Input.GetAxis("Vertical");
        float SideAxis = Input.GetAxis("Horizontal");
        float VerticalAxis = Input.GetAxis("Mouse Y");
        
        return new Vector3(SideAxis, VerticalAxis, ForwardAxis) * speed;
    }
}
