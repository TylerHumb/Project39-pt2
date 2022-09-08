using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterInteract : MonoBehaviour
{
    Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        Vector3 eulerRotation = transform.rotation.eulerAngles;
        eulerRotation.x = 0f;
        transform.rotation = Quaternion.Euler(eulerRotation);
    }

}
