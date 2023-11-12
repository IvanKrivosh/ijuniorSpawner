using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] MoverToTarget _enemy;
    [SerializeField] Transform _target;

    public void CreateEnemy()
    {
        MoverToTarget enemy = Instantiate(_enemy, transform);
        enemy.Init(_target);
    }

    private void Update ()
    {
        Debug.DrawRay(transform.position, transform.up * 10);
    }
}
