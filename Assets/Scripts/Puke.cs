using UnityEngine;

public class Puke : MonoBehaviour
{
    private BoxCollider pukeZone;
    private GameObject player;
    // when you enter the bathroom, if you've finished your burger, start puking when you enter toilet range
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null) Debug.LogError("No player found");
        pukeZone =  GameObject.FindGameObjectWithTag("Toilet").GetComponent<BoxCollider>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
