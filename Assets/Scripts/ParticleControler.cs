using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControler : MonoBehaviour
{
    [SerializeField] ParticleSystem movementParticle;

    [Range(0, 10)]
    [SerializeField] int occurAfterVelocity;

    [Range(0, 0.2f)]
    [SerializeField] float particleFormationPeriod;

    [SerializeField] Rigidbody2D playerRb;

    float counter;
    private void Update()
    {
        counter += Time.deltaTime;

        if (Mathf.Abs(playerRb.velocity.x) > occurAfterVelocity)
        {
            if (counter > particleFormationPeriod)
            {
                movementParticle.Play();
                counter = 0;
            }
        }
    }
}
