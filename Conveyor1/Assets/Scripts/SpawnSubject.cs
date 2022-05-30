using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSubject : MonoBehaviour
{
    [SerializeField] private Subject _subject;
    [SerializeField] private Transform _position;

    private void Start()
    {
        CreateItem();
    }

    public void CreateItem()
    {
        Instantiate(_subject, _position);
    }
}
