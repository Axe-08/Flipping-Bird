using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovementScript : MonoBehaviour
{

    public float cloudSpeed = 5.0f;
    public float deadZone = -23f;
    Controller controller;
    // Update is called once per frame
    private void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        deadZone = controller.spawn_objects_deadzone;
        cloudSpeed = controller.cloud_speed;
    }
    void Update()
    {
        transform.position = transform.position +  cloudSpeed * Time.deltaTime* Vector3.left ;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

    }
}
