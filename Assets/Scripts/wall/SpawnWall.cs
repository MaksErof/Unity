using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    [SerializeField] private Wall _template;
    [SerializeField] private Transform[] _pointInstalations;

    private void Start()
    {
        for(int i = 0; i < _pointInstalations.Length; i++)
        {
            Instantiate(_template, _pointInstalations[i].position, Quaternion.identity);
        }
        
    }
}
