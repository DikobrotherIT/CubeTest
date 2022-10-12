using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    private float _speed;
    private float _target;
    private Vector3 _targetPosition;
    private CubeSpawner _cubeSpawner;

    private void Start()
    {
        _speed = PlayerPrefs.GetFloat("Speed");
        _target = PlayerPrefs.GetFloat("Distance");
        _cubeSpawner = gameObject.GetComponentInParent<CubeSpawner>();
        _targetPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + _target);
        StartCoroutine(MoveToTarget(_targetPosition));
    }

    private IEnumerator MoveToTarget(Vector3 target)
    {
        while(transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
            yield return null;
        }
        _cubeSpawner.StartSpawnTimer();
        Destroy(gameObject);
    }
}
