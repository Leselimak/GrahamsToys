using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private DoorActive door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            door.OpenDoor();
            
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            door.CloseDoor();
        }

       /* if (Input.GetKeyDown(KeyCode.T))
        {
            door.CloseDoor();
        }*/
    }
}
