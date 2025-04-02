using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject closedDoor; // Closed door object
    public GameObject openDoor;   // Open door object
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        closedDoor.SetActive(true);
        openDoor.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if Player enters trigger
        {
            Debug.Log("Player entered, opening door...");
            closedDoor.SetActive(false); // Hide the closed door
            openDoor.SetActive(true);    // Show the open door
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
