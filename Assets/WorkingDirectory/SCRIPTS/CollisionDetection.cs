using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject canvasToActivate;
    void OnTriggerEnter(Collider other)
    {
        
            canvasToActivate.SetActive(true);
        
    }
    void OnTriggerExit(Collider other)
    {
        
            canvasToActivate.SetActive(false);
        
    }
}
