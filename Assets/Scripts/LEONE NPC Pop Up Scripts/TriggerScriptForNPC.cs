using UnityEngine;

public class TriggerScriptForNPC : MonoBehaviour
{
    public Collider playerCol;
    private Collider col;
    private RiseScriptNPC riseScriptNPC;
    
    void Start()
    {
        col = GetComponent<Collider>();
        riseScriptNPC = FindObjectOfType<RiseScriptNPC>();
    }

    
    void Update()
    {
        if (col.bounds.Intersects(playerCol.bounds))
        {
            riseScriptNPC.isActivated = true;
        }
    }
}
