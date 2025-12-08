using UnityEngine;

public class EnemyPatrolling : MonoBehaviour
{
    [SerializeField] private EnemyRotation _enemyRotation;
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private float _speed;

    private Vector3 _position;
    private int _index;

    private void Start()
    {
        _position = GetPosition();
    }

    public void Move()
    {
        if (transform.position == _position)
        {
            _position = GetPosition();
            transform.rotation = _enemyRotation.GetRotation();
        }

        transform.position = Vector2.MoveTowards(transform.position, _position, _speed * Time.deltaTime);
    }

    private Vector3 GetPosition()
    {
        _index++;

        if (_index == _targetPoint.childCount)
            _index = 0;

        Vector3 posiiton = _targetPoint.GetChild(_index).position;

        return posiiton;
    }
}
