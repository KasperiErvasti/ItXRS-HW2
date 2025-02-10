using UnityEngine;
using UnityEngine.InputSystem;

public class LightScript : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();

        Color newColor;
        
        if(light.color.Equals(Color.red)) {
            newColor = Color.blue;
        } else {
            newColor = Color.red;
        }

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            light.color = light.color.Equals(Color.red) ? Color.green : Color.red;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
