using System.Xml.Serialization;
using UnityEngine;

public class MoverToTarget: Mover
{    
    private Transform _target;

    public void Init(Transform target)
    {
        _target = target;        
    }

    private void Update()
    {        
        if (_target != null)
            transform.position = Vector3.MoveTowards(transform.position, _target.position, Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Transform target) && target == _target)        
            Destroy(gameObject);        
    }    
}
