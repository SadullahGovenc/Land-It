using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float force_Amount = 50f, rotate_Amount = 100f;
    [SerializeField]
    private AudioClip rocket_Sound, win_Sound, lose_Sound;
    [SerializeField]
    private ParticleSystem rocket_Particle, wim_Particle, lose_Particle;
    [SerializeField]
    private float transition_Time = 2f;


    private enum State {WIN}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
