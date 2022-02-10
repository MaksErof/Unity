using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallPush : MonoBehaviour
{
    [SerializeField] private float _forceOfPush;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ThrowTheBall(_forceOfPush);
    }

    private void ThrowTheBall(float forceOfPush)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.forward * _forceOfPush, ForceMode.Impulse);
        }
    }

    public void ThrowTheBall()
    {
        _rigidbody.AddForce(Vector3.zero);
    }        
}
