using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMove : MonoBehaviour
{
    [SerializeField] private float _ballSpeed;
    [SerializeField] private float _moveSpeed;

    private Rigidbody _rigidbody;
    private float _move;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Skittles skittles))
        {
            _rigidbody.AddForce(Vector3.zero);
        }
    }

    private void Update()
    {
        MoveBall();
        SetForce(_ballSpeed);
    }

    private void MoveBall()
    {
        _move = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        transform.Translate(_move,0,0);
    }

    private void SetForce(float ballSpeed)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.forward * ballSpeed, ForceMode.Impulse);
        }       
    }
}
