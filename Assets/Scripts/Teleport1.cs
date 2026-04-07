using System;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    public Transform Tp1;
    public Vector3 NewPosition;
    public Quaternion NewRotation;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Teleport");

            other.gameObject.GetComponent<CharacterController>().enabled = false;
            other.gameObject.GetComponent<FirstPersonController>().enabled = false;
            other.gameObject.transform.position = Tp1.position;

            other.gameObject.GetComponent<CharacterController>().enabled = true;

            other.gameObject.GetComponent<FirstPersonController>().enabled = true;
        }
    }

}
