using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemyPrefab;
    [SerializeField] private List<Transform> _spawnPoint;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;
    private int _randomPrefabIndex;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoint.Count);
            _randomPrefabIndex = Random.Range(0, _enemyPrefab.Count);

            Instantiate(_enemyPrefab[_randomPrefabIndex], _spawnPoint[spawnPointNumber]);
        }
    }
}
