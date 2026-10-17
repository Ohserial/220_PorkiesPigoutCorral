using UnityEngine;

public class TriggerScriptForNPC : MonoBehaviour
{
    public Collider playerCol;
    private Collider col;
    public RiseScriptNPC riseScriptNPC;
    private AudioSource aS;
    
    void Start()
    {
        col = GetComponent<Collider>();
        // Please do not uncomment these. They are obsolete. 
        // - AL
        //riseScriptNPC = FindFirstObjectByType<RiseScriptNPC>();
        //aS = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (col.bounds.Intersects(playerCol.bounds))
        {
            riseScriptNPC.isActivated = true;
            // The following code, which plays an audio clip when you collide with this collider is just for testing
            // purposes and can be removed once we get this working.
            // - AL
            // aS.Play();
            // Upon testing, I see that the audio clip, on this script, is playing when we collide, so I belive that the
            // problem we are having is in the communication with the other script.
            // - AL
        }
    }
}
