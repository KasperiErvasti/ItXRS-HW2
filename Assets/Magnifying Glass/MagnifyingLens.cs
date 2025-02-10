using TMPro;
using UnityEngine;

public class MagnifyingLens : MonoBehaviour
{
    public Camera magnifyCamera;
    public Camera playerCamera;

    void Update()
    {
        if (magnifyCamera && playerCamera)
        {
            Vector3 direction = magnifyCamera.transform.position - playerCamera.transform.position;
            // Make the camera always look in the same direction as the player's view
            magnifyCamera.transform.rotation = Quaternion.LookRotation(direction, transform.parent.up);
        }
    }
}
