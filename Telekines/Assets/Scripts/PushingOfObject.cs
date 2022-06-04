using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushingOfObject : MonoBehaviour
{
    [SerializeField] private float _pushSpeed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PushObject();
    }

    private void PushObject()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.right * _pushSpeed, ForceMode.Impulse);
        }
    }
}
