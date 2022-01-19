using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnConveyor : MonoBehaviour
{
    [SerializeField] private Conveyor _template;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _numberOfConveyorParts;

    private void Start()
    {
        CreateConveyor(_template,_spawnPoint);
    }

    public void CreateConveyor(Conveyor template, Transform spawnPoint)
    {
        float sizeOftemplate = _template.transform.localScale.y;
        Vector3 stepForCreatingNewConveyorParts = new Vector3(0, 0, 1);

        for (int i = 0; i < _numberOfConveyorParts; i++)
        {
            Instantiate(_template, spawnPoint.position, Quaternion.Euler(0, 0, 90));
            spawnPoint.position += stepForCreatingNewConveyorParts;
        }
        
    }
}

