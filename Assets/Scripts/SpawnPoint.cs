using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] Enemy _enemy;
    [SerializeField] Ñvilian _target;

    public void CreateEnemy()
    {
        Enemy enemy = Instantiate(_enemy, transform);
        enemy.Init(_target);
    }

    private void Update ()
    {
        Debug.DrawRay(transform.position, transform.up * 10);
    }
}
