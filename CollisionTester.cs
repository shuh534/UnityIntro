using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical);
        transform.position += movement * Time.deltaTime * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " Collision just happened!");
        // check if the object I am colliding to is called "Wall", if it is, delete "Wall"
        if(collision.gameObject.name == "Wall"){
            Destroy(collision.gameObject);
        }
    }
}
