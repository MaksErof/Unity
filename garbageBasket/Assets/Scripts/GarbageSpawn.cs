using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawn : MonoBehaviour
{
    [SerializeField] private Garbage _garbage;
    [SerializeField] private Transform _spawnPosition;

    private void Start()
    {
        Instantiate(_garbage, _spawnPosition.position, Quaternion.identity);
    }
}
