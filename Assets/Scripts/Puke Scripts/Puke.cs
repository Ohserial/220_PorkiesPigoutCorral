using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Puke : MonoBehaviour
{
    public bool canThrowUp = false;
    [SerializeField] private Collider toiletAreaCollider;
    [SerializeField] private Collider playerCollider;
    private GameObject _player;
    private ParticleSystem _particleSystem;
    private AudioSource _audioSource;
    private InputAction _pukeAction;

    
    private void Awake()
    { 
        _player = this.gameObject;
        // _toiletAreaCollider =  GameObject.FindGameObjectWithTag("Toilet").GetComponent<BoxCollider>();
        _particleSystem =  _player.GetComponentInChildren<ParticleSystem>();
        _audioSource = _player.GetComponentInChildren<AudioSource>();
        _pukeAction = InputSystem.actions.FindAction("Attack");
        
    }

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
        if (_pukeAction.WasPressedThisFrame()) ThrowUp();
    }

    private void OnTriggerEnter (Collider other)
    {
        
        Debug.Log("I'm triggered");
        
        if (other == toiletAreaCollider)
        {
            ThrowUp();
        }

        if (other == playerCollider)
        {
            Debug.Log("player");
        }
    }

    private void ThrowUp()
    {
        Debug.Log("I'm not feeling so good... ");
        _particleSystem.Play();
        _audioSource.Play();
    }
}
