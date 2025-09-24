using UnityEngine;

public class VisualModule : ParticleModule
{
    public void Init(Particle particle, Color color)
    {
        base.Init(particle);

        _particle.GetComponent<MeshRenderer>().material.color = color;
    }

    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);
    }
}
