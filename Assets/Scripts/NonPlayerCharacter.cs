using System.Xml.Serialization;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Transform _transform;
    private NPCTarget _target;    

    public void Init(NPCTarget target)
    {
        _target = target;        
    }

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {        
        if (_target != null)
            _transform.position = Vector3.MoveTowards(transform.position, _target.gameObject.transform.position, _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out NPCTarget target) && target == _target)        
            Destroy(gameObject);        
    }    
}
