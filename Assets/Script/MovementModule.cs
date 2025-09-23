using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MovementModule : ParticleModule
{

    public override void Init()
    {
        base.Init();
    }


    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);

        transform.position += direction * speed * deltaTime;
    }
}
