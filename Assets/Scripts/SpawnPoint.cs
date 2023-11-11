using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] NonPlayerCharacter _npc;
    [SerializeField] NPCTarget _target;

    private Transform _transform;

    public void CreateNPC()
    {
        NonPlayerCharacter npc = Instantiate(_npc, _transform);
        npc.Init(_target);
    }

    private void Update ()
    {
        Debug.DrawRay(_transform.position, _transform.up * 10);
    }

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
}
