using UnityEngine;

public class CashierScript : MonoBehaviour
{
    [SerializeField] private GameObject _cashier;
    [SerializeField] private BoxCollider _registerAreaCollider;
    private Vector3 _cashierLowPosition;
    private Vector3 _cashierHighPosition;
    
    private float startTime;
    private float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _cashier.transform.position = _cashierLowPosition;
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        _cashier.transform.position = Vector3.Lerp(_cashierLowPosition, _cashierHighPosition, distCovered);
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (other.gameObject.tag == "Player"
        if (true)
        {
            speed = 0.5f;
            startTime = Time.time;
        }
    }
}
