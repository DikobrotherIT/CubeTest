using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Transform _spawnPoint;
    private float _spawnTime;
    private bool _canSpawn = false;
    
    private void Update()
    {
        if (_canSpawn == true)
        {
            _canSpawn = false;
            Instantiate(_cubePrefab, _spawnPoint);
        }
    }

    private IEnumerator SpawnCooldown()
    {
        _spawnTime = PlayerPrefs.GetFloat("SpawnTime");
        yield return new WaitForSeconds(_spawnTime);
        _canSpawn = true;
    }

    public void StartSpawnTimer()
    {
        StartCoroutine(SpawnCooldown());
    }
}
