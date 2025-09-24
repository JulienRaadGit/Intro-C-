using UnityEngine;

public class LifecycleModule : ParticleModule
{
    private float _timeToLive;

    private float timer;


    public void Init(Particle particle, float timeToLive)
    {
        base.Init(particle);

        _timeToLive = timeToLive;
    }

    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);

        timer += deltaTime;
        if (timer >= _timeToLive)
        {
            GameObject.Destroy(_particle.gameObject);
        }
    }
}
