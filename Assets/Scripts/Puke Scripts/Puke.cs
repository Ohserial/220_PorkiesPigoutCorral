using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Puke : MonoBehaviour
{
    private BoxCollider _toiletAreaCollider;
    private GameObject _player;
    private ParticleSystem _particleSystem;
    private AudioSource _audioSource;
    // when you enter the bathroom, if you've finished your burger, start puking when you enter toilet range
    private void Awake()
    {
        _player = this.gameObject;
        _toiletAreaCollider =  GameObject.FindGameObjectWithTag("Toilet").GetComponent<BoxCollider>();
        _particleSystem =  _player.GetComponentInChildren<ParticleSystem>();
        _audioSource = _player.GetComponentInChildren<AudioSource>();
        
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (_player == null) Debug.LogError("No player found");
        if (_toiletAreaCollider == null) Debug.LogError("No Toilet Found");
        if (_particleSystem == null) Debug.LogError("No Particle System Found");
        Debug.Log("Okay i guess its working then?");
        // ThrowUp();
    }

    private void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            ThrowUp();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider == _toiletAreaCollider)
        {
            ThrowUp();
        }
    }

    private void ThrowUp()
    {
        Debug.Log("I'm not feeling so good... ");
        _particleSystem.Play();
        _audioSource.Play();
    }
}
