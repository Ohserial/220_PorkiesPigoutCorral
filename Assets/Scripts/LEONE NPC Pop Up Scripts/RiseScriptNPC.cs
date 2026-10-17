using UnityEngine;

public class RiseScriptNPC : MonoBehaviour
{
    public bool isActivated = false;
    [SerializeField] private bool hasRisen = false;
    public GameObject npc;
    private AudioSource aS;
    public bool finished = false;
    public float speed = 1;
    public float howMuch = 1;
    
    void Start()
    {
        // For some reason using GetComponent to make the NPC this script should attach to find itself as a GameObject
        // wouldn't work, so I just made the GameObject public, and assigned it the NPC GameObject itself. As such, the
        // GameObject GetComponent call below is PURPOSELY COMMENTED OUT. However, the AudioSource one is not, which is
        // also intentional, since that one is working. 
        // - AL
        //npc = GetComponent<GameObject>();
        aS = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (isActivated && !hasRisen)
        {
            if (npc.transform.position.y < howMuch) 
            {
                npc.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            aS.Play();
            if (npc.transform.position.y == 1 || npc.transform.position.y > howMuch)
            {
                finished = true;
            }
            
        }

        if (isActivated && finished)
        {
            hasRisen = true;
        }
    }
}
