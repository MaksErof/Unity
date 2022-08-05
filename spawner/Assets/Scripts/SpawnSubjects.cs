using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSubjects : MonoBehaviour
{
    [SerializeField] private GameObject[] _subjects;
    [SerializeField] private Transform[] _spawnPosition;
    [SerializeField] private KeyCode[] _buttonOfSubjects;
   
    private void Update()
    {
        Spawn();        
    }

    private void Spawn()
    {
        for(int i = 0; i < _subjects.Length;i++)
        {
            if (Input.GetKeyDown(_buttonOfSubjects[i]))
            {
                Instantiate(_subjects[i], _spawnPosition[i].position, Quaternion.identity);                               
            }
        }
    }
}
