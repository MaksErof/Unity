using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out MovingOfObject movingOfObject))
        {
           movingOfObject.startMovement = true;
        }
    }
}