using System;
using UnityEngine;
using Sirenix.OdinInspector;

public class Teleport : MonoBehaviour
{
    public Transform Tp;


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

            other.gameObject.transform.position = Tp.position;

            other.gameObject.GetComponent<CharacterController>().enabled = true;
            other.gameObject.GetComponent<FirstPersonController>().enabled = true;
        }
    }

}
