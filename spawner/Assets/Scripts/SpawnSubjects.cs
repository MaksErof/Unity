using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSubjects : MonoBehaviour
{
    [SerializeField] private List<GameObject> _subjects;
    [SerializeField] private List<Transform> _spawnPosition;
   
    private void Update()
    {
        Spawn();        
    }

    private void Spawn()
    {
        switch (Input.inputString)
        {
            case "w":
                Instantiate(_subjects[0], _spawnPosition[0].position, Quaternion.identity);
                break;

            case "a":
                Instantiate(_subjects[1], _spawnPosition[1].position, Quaternion.identity);
                break;

            case "s":
                Instantiate(_subjects[2], _spawnPosition[2].position, Quaternion.identity);
                break;

            case "d":
                Instantiate(_subjects[3], _spawnPosition[3].position, Quaternion.identity);
                break;
        }
    }
}
