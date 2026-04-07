using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public InputSystem_Actions inputs;

    public GameObject Camera1;
    public GameObject Camera2;
    private void Awake()
    {
        inputs = new();


    }
    private void OnEnable()
    {

        inputs.Enable();



        //inputs.Player.Jump.performed += ChangeCamera;
    }


    void Update()
    {
        
    }

    private void ChangeCamera(InputAction.CallbackContext context)
    {
       if(Camera1.activeSelf)
        {
            Camera2.SetActive(true);
            Camera1.SetActive(false);
        }
        else
        {
            Camera2.SetActive(false);
            Camera1.SetActive(true);
        }
    }
}
