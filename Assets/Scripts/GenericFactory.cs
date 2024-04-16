using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T prefab;
    [SerializeField] private Transform spawnPoint;

    public T GetNewInstance()
    {
        return Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
