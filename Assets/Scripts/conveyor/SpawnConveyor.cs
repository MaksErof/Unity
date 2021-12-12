using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnConveyor : MonoBehaviour
{
    [SerializeField] private Conveyor _template;
    [SerializeField] private Transform _spawnPoint;
    bool isTouch = false;

    private void Start()
    {
        CreateConveyor(_template,_spawnPoint);
    }

    public void CreateConveyor(Conveyor _template, Transform spawnPoint)
    {
        Vector3 spawnPosition = new Vector3(0,0,1);

        for(int i = 0; i < 20; i ++)
        {
            Instantiate(_template, spawnPoint.position, Quaternion.Euler(0, 0, 90));
            spawnPoint.position += spawnPosition;
        }
    }
}

