
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScoreTriggerScript : MonoBehaviour
{

    public LogicScript logic;
    public Animator animator;
    public AudioManager audioManager;
    Controller controller;
    // Start is called before the first frame update
    void Start()
    {   
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        if(Random.Range(0.0f, 1.0f) > controller.coin_spawnrate) Destroy(gameObject);
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        audioManager = GameObject.FindGameObjectWithTag("music").GetComponent<AudioManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.AddScore();
            audioManager.playSFX(audioManager.coin, 1);
            Destroy(gameObject);
        }
            
    }
}
