using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out MovingOfObject movingOfObject))
        {
            movingOfObject.MoveObject();
        }
    }
}
