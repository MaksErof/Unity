using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    private MovingOfObject _movingOfObject;

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Subject subject))
        {
            _movingOfObject.MoveObject();
        }
    }
}
