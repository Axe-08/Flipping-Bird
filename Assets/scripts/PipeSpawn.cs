using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    private float spawnrate = 3;
    private float time = 0;
    private float spawnOffset = 5;
    Controller controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        spawnOffset = controller.pipe_spawn_offset;
        spawnrate = controller.pipe_spawnrate;
        Spawn();   
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnrate)
        {
            time += Time.deltaTime;
        }
        else {
            Spawn();
            time = 0;
        }
    }
    
    public void Spawn()
    {
       float upperlimit = transform.position.y - spawnOffset;
        float lowerlimit = transform.position.y + spawnOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }

}
