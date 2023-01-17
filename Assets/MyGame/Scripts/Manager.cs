using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject collectable;
    public bool debugPoints;
    private List<Transform> spawnPoints = new();

    private void Start()
    {
        SpawnCollectable();
    }
    public void SpawnCollectable()
    {
        spawnPoints = GetComponentsInChildren<Transform>().ToList();
        spawnPoints.Remove(transform);
        GameObject col = Instantiate(collectable);
        col.transform.position = spawnPoints[Random.Range(0, spawnPoints.Count)].position;
        col.GetComponent<Collect>().mang = this;
    }

    private void OnDrawGizmos()
    {
        if (!debugPoints) return;
        spawnPoints = GetComponentsInChildren<Transform>().ToList();
        spawnPoints.Remove(transform);
        Gizmos.color = Color.white;
        foreach (Transform point in spawnPoints) Gizmos.DrawSphere(point.position, 0.2f);
    }
}  
