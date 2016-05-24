using UnityEngine;
using System.Collections;

public class BossWeaponController : MonoBehaviour
{
    public GameObject shot;
    public Transform[] shotSpawns;
    public float fireRate;
    public float delay;

    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Transform shotSpawn = shotSpawns[Random.Range(0, shotSpawns.Length)];
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audio.Play();
    }
}
