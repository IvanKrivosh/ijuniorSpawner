using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    const int LengthRay = 10;

    [SerializeField] MoverToTarget _enemy;
    [SerializeField] Transform _target;

    public void CreateEnemy()
    {
        MoverToTarget enemy = Instantiate(_enemy, transform);
        enemy.Init(_target);
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, transform.up * LengthRay);
    }
}
