using System.Drawing;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Particle ParticlePrefab;
    [SerializeField] private float rate;
    [SerializeField] private float minTimeToLive;
    [SerializeField] private float maxTimeToLive;
    [SerializeField] private float minSpeedParticle;
    [SerializeField] private float maxSpeedParticle;
    [SerializeField] private Vector3 gravity;

    [SerializeField] private bool lifecycleModule;
    [SerializeField] private bool movementModule;
    [SerializeField] private bool visualModule;

    private float timer;


    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f /  rate)
        {
            timer = 0;

            CreateParticle();
        }
    }

    void CreateParticle()
    {
        Particle particle = Instantiate(ParticlePrefab, transform);
        particle.Init();

        if (movementModule)
        {
            MovementModule mod = new MovementModule();
            mod.Init(particle,
                Random.onUnitSphere,
                Random.Range(minSpeedParticle,
                maxSpeedParticle),
                gravity
            );
            
            particle.AddModule(mod);
        }

        if (lifecycleModule)
        {
            LifecycleModule mod = new LifecycleModule();
            mod.Init(particle, Random.Range(minTimeToLive, maxTimeToLive));

            particle.AddModule(mod);
        }

        if (visualModule)
        {
            VisualModule mod = new VisualModule();
            mod.Init(particle, Random.ColorHSV());

            particle.AddModule(mod);
        }
    }
}
