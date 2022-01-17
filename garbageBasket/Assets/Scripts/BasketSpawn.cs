using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketSpawn : MonoBehaviour
{
    [SerializeField] private Basket _basket;
    [SerializeField] private Transform _spawnPosition;
    
    private void Start()
    {
        Instantiate(_basket, _spawnPosition.position, Quaternion.identity);
    }
}
