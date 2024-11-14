using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb_script : MonoBehaviour
{   
   // public touchInput tinput;

    public Rigidbody2D myrb;
    private float upStrength =10;
    public LogicScript logic;
    public bool isBirdAlive = true;
    public Animator Animator;
    AudioManager music;
    Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        Animator.SetBool("dead", false);
        music=GameObject.FindGameObjectWithTag("music").GetComponent<AudioManager>();
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        upStrength = controller.bird_flap_strength;
        myrb.gravityScale = controller.bird_gravity_scale;
        myrb.drag = controller.bird_linear_drag;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&isBirdAlive)
        {
            myrb.velocity = Vector2.up * upStrength;
            music.playSFX(music.flap,1);
        }
        if(transform.position.y < controller.bird_dead_lowerborder||transform.position.y>controller.bird_dead_upperborder) {
            logic.GameOver();
            if (isBirdAlive) { music.playSFX(music.death,0.7f); }
            isBirdAlive=false;
            Animator.SetBool("dead", true);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        isBirdAlive=false;
        music.playSFX(music.death,0.7f);
        Animator.SetBool("dead", true);
    }

}
