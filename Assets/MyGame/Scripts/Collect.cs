using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject player;
    public Manager mang;

    void Start()
    {
        //winText.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //transform.position = player.transform.position;
            transform.SetParent(other.transform);
            Debug.Log("collected");
        }

        if (other.CompareTag("WinArea"))
        {
            mang.SpawnCollectable();
            Destroy(gameObject);
        }
    }

}
