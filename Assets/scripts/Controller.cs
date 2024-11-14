using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float bird_flap_strength = 11;
    public float bird_linear_drag = 1.5f;
    public float bird_gravity_scale = 2;
    public float bird_dead_upperborder = 6;
    public float bird_dead_lowerborder = -4.8f;
    public float spawn_objects_deadzone = -20;
    public float cloud_speed = 5;
    public float pipe_speed = 3;
    public int score_multiplier = 1;
    public float coin_spawnrate = 0.9f;
    public float pipe_spawnrate;
    public float pipe_spawn_offset;
    public float cloud_spawnrate=4;
    public float cloud_upperborder;
    public float cloud_lowerborder;
}
