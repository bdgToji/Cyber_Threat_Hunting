using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class Rifle : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject hitObject;
    [SerializeField] private Slider slider;

    [Header("Audio")]
    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip sfx;
    [SerializeField] private AudioClip chargeSfx;

    private float shotTime = 0;
    private float timeDelay = 1.5f;
    private bool canShoot = true;
    private float timer = 0;

    public void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            shotTime = Time.time;
            slider.value = 0;

            src.PlayOneShot(sfx);

            GameObject blast = Instantiate(hitObject);
            blast.transform.position = shootPoint.position;
            blast.transform.rotation = shootPoint.rotation;
            blast.GetComponent<Animator>().Play("Blast_anim", 0, 0.0f);

            StartCoroutine(shotDelay(blast));
            src.PlayOneShot(chargeSfx);
        }
    }

    private IEnumerator shotDelay(GameObject blast)
    {
        yield return new WaitForSeconds(1);
        Destroy(blast);
    }

    private void Update()
    {
        timer += Time.time;
        if (Time.time - shotTime >= timeDelay)
        {
            canShoot = true;
        }

        if (!canShoot)
        {
            slider.value += Time.deltaTime;
        }
    }
}
