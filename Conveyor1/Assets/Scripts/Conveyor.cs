using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Conveyor : MonoBehaviour
{
    [SerializeField] private Transform _endPosition;
    [SerializeField] private float _conveyorSpeed;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, _endPosition.position, _conveyorSpeed * Time.deltaTime);
    }
}