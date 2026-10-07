using System;
using UnityEngine;

public class Puke : MonoBehaviour
{
    private BoxCollider pukeZone;
    private GameObject player;
    private ParticleSystem pukeSystem;
    // when you enter the bathroom, if you've finished your burger, start puking when you enter toilet range
    private void Awake()
    {
        player = this.gameObject;
        pukeZone =  GameObject.FindGameObjectWithTag("Toilet").GetComponent<BoxCollider>();
        pukeSystem =  player.GetComponentInChildren<ParticleSystem>();
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (player == null) Debug.LogError("No player found");
        if (pukeZone == null) Debug.LogError("No Toilet Found");
        if (pukeSystem == null) Debug.LogError("No Particle System Found");
        Debug.Log("Okay i guess its working then?");
        // pukeSystem.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>() == pukeZone)
        {
            pukeSystem.Play();
        }
    }

    private void ThrowUp()
    {
        Debug.Log("I'm not feeling so good... ");
        pukeSystem.Play();
    }
}
