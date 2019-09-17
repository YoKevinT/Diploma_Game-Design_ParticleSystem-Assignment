using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MouseMovement
{
    private ParticleSystem particlesSystem;
    public int amountOfParticle;

    void Start()
    {
        particlesSystem = gameObject.GetComponent<ParticleSystem>();
        particlesSystem.Stop(true);
    }

    public void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            particlesSystem.Emit(amountOfParticle);
        }
    }
}
