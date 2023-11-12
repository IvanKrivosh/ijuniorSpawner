using UnityEngine;

public class Ñvilian : NonPlayerCharacter
{   
    [SerializeField] Path _path;        
    
    private Transform _currentPoint;

    private void Update()
    {
        if (_currentPoint == null || transform.position == _currentPoint.position)
            _currentPoint = _path.GetNextPoint();

        transform.position = Vector3.MoveTowards(transform.position, _currentPoint.position, _speed * Time.deltaTime);
    }   
}
