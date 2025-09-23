using System.Collections.Generic;
using UnityEngine;

public class Particule : MonoBehaviour
{
    private Vector3 direction;
    private float timeToLive;
    private int timer;
    private float speed;

    private List<ParticleModule> modules;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = Random.onUnitSphere;
        speed = Random.Range(-10, 10);
        timeToLive = Random.Range(3, 8);

        modules = new List<ParticleModule>();

        //modules.Add

        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction * speed * Time.deltaTime;

        timer += (int)Time.deltaTime;
        if (timer >= timeToLive)
        {
            Destroy(gameObject);
        }
    }
}
