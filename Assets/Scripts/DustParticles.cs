using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class DustParticles : MonoBehaviour
{
    private Movement movement;
    private ParticleSystem particles;

    public Vector3 offset;

    void Start()
    {
        movement = FindObjectOfType<Movement>();
        particles = GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        var particlesActive = movement.OnGround && movement.HasInput;
        var emission = particles.emission;
        emission.enabled = particlesActive;
    }

    void LateUpdate()
    {
        var shape = particles.shape;
        shape.position = movement.transform.position + offset;
    }
}
