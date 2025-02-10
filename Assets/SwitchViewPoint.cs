using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchViewPoint : MonoBehaviour
{

    public GameObject player;
    public Transform roomPosition;
    public Transform externalViewPoint;
    public InputActionReference toggleViewAction;

    private bool isInRoom = true;

    void Start()
    {
        toggleViewAction.action.Enable();
        toggleViewAction.action.performed += (ctx) => {
            
            if (isInRoom)
            {
                player.transform.position = externalViewPoint.position;
            }
            else
            {
                player.transform.position = roomPosition.position;
            }

            isInRoom = !isInRoom;

        };
    }


}


