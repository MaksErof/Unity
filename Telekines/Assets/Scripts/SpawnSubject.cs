using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSubject : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private Subject _subject;

    private void Start()
    {
        CreateItem();
    }

    private void CreateItem()
    {
        for (int i = 0; i < _spawnPoint.Length; i++)
        {
            Instantiate(_subject, _spawnPoint[i].position, Quaternion.identity);
        }        
    }
}

