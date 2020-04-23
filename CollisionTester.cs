using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTester : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
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
     }

}
