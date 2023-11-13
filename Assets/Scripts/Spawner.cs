using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float _spawnTime = 0.5f;

    private List<SpawnPoint> _points;    
    private System.Random _random = new System.Random();
    private IEnumerator _spawnCoroutine;

    private int NextPoint => _random.Next(0, _points.Count);

    private void Awake()
    {
        _points = GetComponentsInChildren<SpawnPoint>().ToList();
    }

    private void OnEnable()
    {
        _spawnCoroutine = SpawnEnemy();
        StartCoroutine(_spawnCoroutine);
    }

    private void OnDisable()
    {
        StopCoroutine(_spawnCoroutine);
    }

    private IEnumerator SpawnEnemy() 
    {        
        while (enabled)
        {
            _points[NextPoint].CreateEnemy();
            yield return new WaitForSeconds(_spawnTime);
        }        
    }
}
