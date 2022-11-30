using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerContreller : MonoBehaviour
{
    public GameObject focus;

    private Vector3 offset;

   
    void Start()
    {
        offset = transform.position - focus.transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = focus.transform.position + offset;
    }
}
