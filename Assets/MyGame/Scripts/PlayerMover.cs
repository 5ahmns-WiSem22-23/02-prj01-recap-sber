using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public KeyCode w;
    public KeyCode a;
    public KeyCode s;
    public KeyCode d;

    public float speed;

    public GameObject winText;

    void Start()
    {
        winText.SetActive(false);
    }
    private void FixedUpdate()
    {
        Vector3 dir = new Vector3(0, 0, 0);

        if (Input.GetKey(w)) { dir.y += 1; }
        if (Input.GetKey(a)) { dir.x += -1; }
        if (Input.GetKey(s)) { dir.y += -1; }
        if (Input.GetKey(d)) { dir.x += 1; }

        transform.position += dir.normalized * speed * Time.deltaTime;

        if (GameObject.FindGameObjectsWithTag("Collectable") == null)
        {
            winText.SetActive(true);
        }
    }

}
