using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class MovingOfObjects : MonoBehaviour
{
    [SerializeField] private float _objectSpeed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void MoveAround()
    {
        _rigidbody.AddForce(Vector3.left * _objectSpeed);
    }

    private void OnTriggerStay(Collider other)
    {
        MoveAround();
    }
}
