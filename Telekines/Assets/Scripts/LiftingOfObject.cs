using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class LiftingOfObject : MonoBehaviour
{    
    [SerializeField] private float _liftingSpeed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ManageOfObject();
    }

    private void ManageOfObject()
    {        
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector3.up * _liftingSpeed);
        }
    }
}
