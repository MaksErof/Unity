using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovingOfObject : MonoBehaviour
{
    public bool startMovement = false;

    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        if(startMovement == true)
        {
            MoveObject();
        }
    }

    public void MoveObject()
    {
        transform.Translate(Vector3.left * _movingSpeed * Time.deltaTime);
    }
}
