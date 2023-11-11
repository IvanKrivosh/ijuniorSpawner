using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] NonPlayerCharacter _npc;

    private Transform _transform;

    public void CreateNPC()
    {
        Instantiate(_npc, _transform);        
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
