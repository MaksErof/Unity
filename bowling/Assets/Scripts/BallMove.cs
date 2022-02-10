using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Rigidbody _rigidbody;
    private float _move;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();        
    }

    private void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        _move = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        transform.Translate(_move, 0, 0);
    }
}
