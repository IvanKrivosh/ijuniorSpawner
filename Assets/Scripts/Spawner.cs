using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float _spawnTime = 0.5f;

    private List<SpawnPoint> _points;
    private float _passedTime;
    private System.Random _random = new System.Random();

    private int NextPoint => _random.Next(0, _points.Count);

    private void Awake()
    {
        _points = GetComponentsInChildren<SpawnPoint>().ToList();
    }

    private void Update()
    {
        _passedTime += Time.deltaTime;

        if (_passedTime >= _spawnTime)
        {
            _points[NextPoint].CreateNPC();
            _passedTime = 0;
        }
    }
}
