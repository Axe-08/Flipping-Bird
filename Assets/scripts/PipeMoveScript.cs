using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    private float pipeSpeed = 5.0f;
    private float deadZone = -23f;
    Controller controller;

    void Start()
    {
        controller= GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        deadZone = controller.spawn_objects_deadzone;
        pipeSpeed = controller.pipe_speed;
    }
    // Update is called once per frame
    void Update()
    {   
        transform.position = transform.position +  pipeSpeed*Time.deltaTime* Vector3.left ;
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

    }

}
