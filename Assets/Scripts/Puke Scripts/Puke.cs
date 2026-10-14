using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Puke : MonoBehaviour
{
    public bool canThrowUp = false;
    [SerializeField] private BoxCollider toiletAreaCollider;
    private GameObject _player;
    private ParticleSystem _particleSystem;
    private AudioSource _audioSource;
    private InputAction _pukeAction;
    // when you enter the bathroom, if you've finished your burger, start puking when you enter toilet range
    private void Awake()
    {
        _player = this.gameObject;
        // _toiletAreaCollider =  GameObject.FindGameObjectWithTag("Toilet").GetComponent<BoxCollider>();
        _particleSystem =  _player.GetComponentInChildren<ParticleSystem>();
        _audioSource = _player.GetComponentInChildren<AudioSource>();
        _pukeAction = InputSystem.actions.FindAction("Attack");
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (_player == null) Debug.LogError("No player found");
        if (toiletAreaCollider == null) Debug.LogError("No Toilet Found");
        if (_particleSystem == null) Debug.LogError("No Particle System Found");
        Debug.Log("Okay i guess its working then?");
        // ThrowUp();
        canThrowUp = true;
    }

    private void Update()
    {
        if (_pukeAction.WasPressedThisFrame())
        {
            ThrowUp();
        }
    }

    private void OnTriggerEnter (Collider other)
    {
            if (canThrowUp)ThrowUp();
    }

    private void ThrowUp()
    {
        Debug.Log("I'm not feeling so good... ");
        _particleSystem.Play();
        _audioSource.Play();
    }
}
