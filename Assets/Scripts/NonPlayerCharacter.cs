using System.Xml.Serialization;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Transform _transform;    

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.position += _transform.up * _speed * Time.deltaTime;
    }   
}
