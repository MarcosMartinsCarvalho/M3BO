using UnityEngine;

public class endingscript : MonoBehaviour
{
    public Transform teleportDestination;
    public GameObject objectToTeleport;
    public GameObject objectToTeleport2;
    public GameObject objectToTeleport3;// GameObject to teleport
    public KeyCode teleportKey = KeyCode.F;
    
    private bool canTeleport = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            canTeleport = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canTeleport = false;
        }
    }

    private void Update()
    {
        if (canTeleport && Input.GetKeyDown(teleportKey))
        {
            if (objectToTeleport != null && teleportDestination != null)
            {
                Teleport(objectToTeleport);
                Teleport2(objectToTeleport);
                Teleport3(objectToTeleport);
            }
            
        }
    }

    private void Teleport(GameObject objectToTeleport)

    {
        objectToTeleport.transform.position = teleportDestination.position;
    }
    private void Teleport2(GameObject objectToTeleport2)

    {
        objectToTeleport.transform.position = teleportDestination.position;
    }
    private void Teleport3(GameObject objectToTeleport3)

    {
        objectToTeleport.transform.position = teleportDestination.position;
    }
}
