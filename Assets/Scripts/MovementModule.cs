using UnityEngine;

public class MovementModule : ParticleModule
{
    private Vector3 _gravity;

    private Vector3 _velocity;


    public void Init(Particle particle, Vector3 direction, float speed, Vector3 gravity)
    {
        base.Init(particle);

        _gravity = gravity;
        _velocity = direction * speed;
    }

    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);

        _particle.transform.position += _velocity * deltaTime;

        _velocity += _gravity * deltaTime;
    }
}
