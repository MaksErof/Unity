using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovingOfObject : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void MoveObject()
    {
        _rigidbody.AddForce(Vector3.left * _movingSpeed * Time.deltaTime);
    }
}
