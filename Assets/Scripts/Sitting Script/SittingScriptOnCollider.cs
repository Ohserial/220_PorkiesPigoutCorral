using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class SittingScriptOnCollider : MonoBehaviour
{
    public Collider col;
    public Collider playerCol;
    public GameObject thePlayerCamera;
    public bool isColliding = false;
    public bool isNotColliding = true;
    

    void Start()
    {
        col = GetComponent<Collider>();
        isColliding = false;
        isNotColliding = true;
    }

    // In start, the script automatically gets the collider of the object it is on (should be an empty GameObject with
    // the "Is Trigger" box clicked). It also sets the values of "isColliding" and "isNotColliding" where they should
    // start. I know they were defined that way already, but I don't know why it's not working.
    // - AL
   
    void Update()
    {
        if (col.bounds.Intersects(playerCol.bounds))
        { 
           isNotColliding = false;
           thePlayerCamera.transform.localScale -= new Vector3(0, 0.0075f, 0); // READ B4 CHANGING: The values here are
                                                                               // so small because if they become too
                                                                               // big, the player just clips though the
                                                                               // ground. This should work if the camera
                                                                               // rig's y value starts at 0.
                                                                               // - AL
           isColliding = true; 
           Debug.Log("It collided");
        }
        
        if (!col.bounds.Intersects(playerCol.bounds) && isNotColliding == false)
        {
            
           thePlayerCamera.transform.localScale += new Vector3(0, 0.0075f, 0); // READ B4 CHANGING: The values here are
                                                                               // so small because if they become too
                                                                               // big, the player just clips though the
                                                                               // ground. This should work if the camera
                                                                               // rig's y value starts at 0.
                                                                               // -AL
           isColliding = false;
           isNotColliding = true;
           Debug.Log("The event is triggering, but it's not doing what we want");
        }
    }
    
    // In Update, if the bounds of the collider of the GameObject the script is attached to collides with the bounds of
    // the collider of the playerCol (you need to give the empty GameObject parent of the Camera Rig Building Block a
    // collider and then drag the GameObject into the well for "playerCol" to set up, in addition to dragging the Camera
    // Rig Building Block itself, not the empty parent, into the "thePlayerCamera" well) it will set the scale of the
    // Camera Rig to 0.0075 on the Y axis. It is also supposed to set isNotColliding to false and isColliding to true.
    // That part appears to be working; at least the camera is getting lower on collision. After that, it is supposed to
    // detect if the player was colliding with the collider last frame, by checking if it is not colliding with the
    // bounds anymore and seeing if isNotColliding is false. If both those conditions are met, the camera is supposed to
    // rise again, as isColliding is set to false, while isNotColliding is set to true.
    // However, as far as I can tell, nothing is happening when the colliders' bounds stop intersecting. I don't know
    // why. I would appriciate someone else taking a crack at this, as I can't figure it out.
    // - AL
    
    
    
    
    // Below here is commented out stuff. I commented this out because OnTriggerEnter wasn't working at all and I
    // couldn't get it to.
    // - AL
    
    
    /*private void OnTriggerEnter(Collider other)
    {
        if (other == playerCol)
        {
            thePlayerCamera.transform.localScale -= new Vector3(0, 0.0075f, 0); // READ B4 CHANGING: The values here are so small because if they become too big, the player just clips though the ground. This should work if the camera rig's y value starts at 0.
            //isColliding = true; 
            //isNotColliding = false;
            //Debug.Log("It collided, even in this stupid version");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == playerCol)
        {
            thePlayerCamera.transform.localScale += new Vector3(0, 0.0075f, 0); // READ B4 CHANGING: The values here are so small because if they become too big, the player just clips though the ground. This should work if the camera rig's y value starts at 0.
        }
    }
    */
}
