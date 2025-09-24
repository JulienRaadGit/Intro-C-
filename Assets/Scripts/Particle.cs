using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    private List<ParticleModule> modules;


    public void Init()
    {
        modules = new List<ParticleModule>();
    }

    public void AddModule(ParticleModule module)
    {
        modules.Add(module);
    }

    void Update()
    {
        for (int i = 0; i < modules.Count; i++)
        {
            modules[i].Update(Time.deltaTime);
        }
    }
}
