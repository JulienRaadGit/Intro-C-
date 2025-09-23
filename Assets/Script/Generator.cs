using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject ParticlePrefab;
    [SerializeField] private float rate;
    [SerializeField] private float minSpeedParticle;
    [SerializeField] private float maxSpeedParticle;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f / rate)
        {
            timer = 0;

            Instantiate(ParticlePrefab,transform.position,Quaternion.identity);
        }
    }
}
