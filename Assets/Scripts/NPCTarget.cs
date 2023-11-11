using UnityEngine;

public class NPCTarget : MonoBehaviour
{
    [SerializeField] float _speed = 2f;
    [SerializeField] Path _path;
        
    private Transform _transform;
    private Transform _currentPoint;

    private void Awake()
    {
        _transform = GetComponent<Transform>();        
    }

    private void Update()
    {
        if (_currentPoint == null || _transform.position == _currentPoint.position)
            _currentPoint = _path.GetNextPoint();

        _transform.position = Vector3.MoveTowards(_transform.position, _currentPoint.position, _speed * Time.deltaTime);
    }   
}
