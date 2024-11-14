using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloudSpawningScript : MonoBehaviour
{
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject cloud4;
    public GameObject cloud5;
    public GameObject cloud6;
    public GameObject cloud7;
    public GameObject cloud8;
    public float upperlimit = 6.5f;
    public float lowerlimit = -5f;
    private float time = 0;
    public float cloudSpawnRate = 15;
    Controller controller;
    // Start is called before the first frame update
    void Start()
    {
        controller=GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        upperlimit = controller.cloud_upperborder;
        lowerlimit = controller.cloud_lowerborder;
        RandomSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < cloudSpawnRate)
        {
            time += (Time.deltaTime+(Random.Range(0,1f)*Time.deltaTime));
        }
        else
        {
            RandomSpawn();
            time = 0;
        }

    }

    public void RandomSpawn()
    {
        int sel = Random.Range(0, 8);
        switch (sel)
        {
        case 0: SpawnCloud1(); break;
        case 1: SpawnCloud2(); break;
        case 2: SpawnCloud3(); break;
        case 3: SpawnCloud4(); break;
        case 4: SpawnCloud5(); break;
        case 5: SpawnCloud6(); break;
        case 6: SpawnCloud7(); break;
        case 7: SpawnCloud8(); break;
        default: break;
        }
    }

    public void SpawnCloud1()
    {
        Instantiate(cloud1, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }
    public void SpawnCloud2()
    {
        Instantiate(cloud2, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }
    public void SpawnCloud3()
    {
        Instantiate(cloud3, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }
    public void SpawnCloud4()
    {
        Instantiate(cloud4, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }
    public void SpawnCloud5()
    {
        Instantiate(cloud5, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }
    public void SpawnCloud6()
    {
        Instantiate(cloud6, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }
    public void SpawnCloud7()
    {
        Instantiate(cloud7, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }
    public void SpawnCloud8()
    {
        Instantiate(cloud8, new Vector3(transform.position.x, Random.Range(lowerlimit, upperlimit), 0), transform.rotation);
    }

}
