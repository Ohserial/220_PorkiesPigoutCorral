using UnityEngine;

public class RiseScriptNPC : MonoBehaviour
{
    public bool isActivated = false;
    private GameObject npc;
    private AudioSource aS;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        npc = GetComponent<GameObject>();
        aS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated)
        {
            npc.transform.position += new Vector3(0, 4, 0) * Time.deltaTime;
            aS.PlayOneShot(aS.clip);
        }
    }
}
