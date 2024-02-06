using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float speedGainPerSecond = 0.1f;

    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }
}
