using System.Collections;
using UnityEngine;

public class TurretAI : MonoBehaviour
{
    [SerializeField] public GameObject Player;
    private Transform LastLocationOfPlayer;
    private bool canShoot = true;

    [SerializeField] private Transform head;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Projectile projectile;
    [SerializeField] private float projectileSpeed = 6;

    [SerializeField] private ItemDrop itemDrop;
    [SerializeField] private bool hasBonusDrop = false;

    [Header("Audio")]
    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip sfx;

    private void Start()
    {
        InvokeRepeating(nameof(shoot), 2, 2);
    }

    private void FixedUpdate()
    {
        LookAtPlayer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blast"))
        {
            Debug.Log("Enemy Shot");
            if (hasBonusDrop)
            {
                Debug.Log("Item droped!");
                GameObject newItem = Instantiate(itemDrop.DropItem());
                newItem.transform.position = transform.position;
            }
            Destroy(gameObject);
        }
    }

    private void LookAtPlayer()
    {
        head.transform.LookAt(Player.transform.position);
    }

    private void shoot()
    {
        src.clip = sfx;
        src.Play();
        Projectile newProjectile = Instantiate(projectile);
        newProjectile.transform.position = shootPoint.position;
        newProjectile.LastLocationOfPlayer = Player.transform.position;
        //newProjectile.transform.position = Vector3.MoveTowards(newProjectile.transform.position, LastLocationOfPlayer.position, projectileSpeed * Time.deltaTime);
    }

    private IEnumerator reload()
    {
        yield return new WaitForSeconds(5);
        canShoot = true;
    }
}
