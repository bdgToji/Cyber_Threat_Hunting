using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    [SerializeField] private CapsuleCollider hitBox;
    [SerializeField] private GameObject shootPoint;
    [SerializeField] private GameObject hitObject;
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private TMP_Text ammoCount;

    [Header("Audio")]
    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip sfx;
    [SerializeField] private AudioClip reloadSfx;

    private int currAmmo;
    private int maxAmmo = 5;
    private List<GameObject> blasts = new List<GameObject>();

    private void Awake()
    {
        currAmmo = maxAmmo;
        ammoCount.text = currAmmo.ToString();

        hitBox = GetComponent<CapsuleCollider>();
        if (hitBox == null)
        {
            hitBox = gameObject.AddComponent<CapsuleCollider>();
        }
        hitBox.isTrigger = true;
        hitBox.center = new Vector3(0, 0, 3.15f);
        hitBox.radius = 0.5f;
        hitBox.height = 6;
        hitBox.direction = 2;

        hitBox.enabled = false;
    }

    public void Shoot()
    {
        if (currAmmo == 0) return;
        currAmmo--;
        ammoCount.text = currAmmo.ToString();

        hitBox.enabled = true;

        src.clip = sfx;
        src.PlayOneShot(sfx);

        GameObject newHitObject = Instantiate(hitObject);
        newHitObject.transform.position = new Vector3(shootPoint.transform.position.x, shootPoint.transform.position.y, shootPoint.transform.position.z);
        newHitObject.transform.rotation = shootPoint.transform.rotation;
        newHitObject.GetComponent<Animator>().Play("Blast_anim", 0, 0.0f);
        blasts.Add(newHitObject);

        particleSystem.transform.position = shootPoint.transform.position;
        //particleSystem.transform.rotation = shootPoint.transform.rotation;
        particleSystem.Play();

        foreach (GameObject blast in blasts)
        {
            StartCoroutine(shotDelay(blast));
        }
        //StartCoroutine(shotDelay());

    }

    public IEnumerator shotDelay(GameObject blast)
    {
        yield return new WaitForSeconds(1);
        hitBox.enabled = false;
        Destroy(blast);
        /*foreach (GameObject blast in blasts)
        {
            Destroy(blast);
        }*/
    }

    public void Reload(SelectEnterEventArgs args)
    {
        if (currAmmo == maxAmmo) return;

        src.clip = reloadSfx;
        src.PlayOneShot(reloadSfx);
        currAmmo++;
        ammoCount.text = currAmmo.ToString();
        Destroy(args.interactableObject.transform.gameObject);
    }
}
