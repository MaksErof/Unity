using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkittlesBuilder : MonoBehaviour
{
    [SerializeField] private float _numberOfRows;
    [SerializeField] private Skittles _skittles;
    [SerializeField] private Transform _builderPoint;

    private void Start()
    {
        Instantiate(_skittles, _builderPoint);
    }
}