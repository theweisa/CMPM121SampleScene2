using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Rigidbody rb;
    public float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        controller.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        direction = Camera.main.transform.TransformDirection(direction);
        direction.y = 0f;
        if (direction.magnitude >= 0.1f) {
            controller.Move(direction*speed*Time.deltaTime);
        }
    }
}
