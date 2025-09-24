using UnityEngine;

public class ParticleModule
{
    protected Particle _particle;


    public virtual void Init(Particle particle)
    {
        _particle = particle;
    }

    public virtual void Update(float deltaTime)
    {

    }
}
