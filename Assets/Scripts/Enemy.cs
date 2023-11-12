using System.Xml.Serialization;
using UnityEngine;

public class Enemy: NonPlayerCharacter
{    
    private Ñvilian _target;

    public void Init(Ñvilian target)
    {
        _target = target;        
    }

    private void Update()
    {        
        if (_target != null)
            transform.position = Vector3.MoveTowards(transform.position, _target.gameObject.transform.position, _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ñvilian target) && target == _target)        
            Destroy(gameObject);        
    }    
}
