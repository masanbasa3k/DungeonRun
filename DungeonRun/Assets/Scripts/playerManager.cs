using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    public float speed = 5.0f;         // Karakterin hareket hızı
    public float deceleration = 0.1f;  // Yavaşlama katsayısı
    public float boundary = 2.0f;      // Karakterin gidebileceği sınırlar
    private Vector3 currentVelocity = Vector3.zero;
    public GameObject CoinParticlePrefeb;
    public GameObject BloodParticlePrefeb;

    public GameManager gameManager;

    void Update()
    {
        // Yatay eksendeki girişleri al
        float horizontalInput = Input.GetAxis("Horizontal");

        // Hedef hızı hesapla
        Vector3 targetVelocity = new Vector3(horizontalInput * speed, 0, 0);

        // Mevcut hızı hedef hıza doğru yavaşlama katsayısı ile güncelle
        currentVelocity = Vector3.Lerp(currentVelocity, targetVelocity, deceleration);

        // Karakteri hareket ettir
        transform.Translate(currentVelocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col)
    {
        // check layer of the object is that coin or spike
        if (col.gameObject.layer == 8)
        {
            // Destroy the coin
            Destroy(col.gameObject);
            // Instantiate the particle
            InstantiateParticle(CoinParticlePrefeb, transform.position);
            // Increase the score
            gameManager.score+=100;
            gameManager.speedScore+=100;
        }
        else if (col.gameObject.layer == 9)
        {
            InstantiateParticle(BloodParticlePrefeb, transform.position);
            gameManager.live--;
        }
    }

    public void InstantiateParticle(GameObject particlePrefab, Vector3 position)
    {
        GameObject particle = Instantiate(particlePrefab, position, Quaternion.identity);
        Destroy(particle, particle.GetComponent<ParticleSystem>().main.duration + particle.GetComponent<ParticleSystem>().main.startLifetime.constantMax);
    }
}
