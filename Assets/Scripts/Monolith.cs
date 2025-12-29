using System.Collections;
using UnityEngine;

public class Monolith : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject barrier;
    private bool canSpawn;
    private float spawnTime = 3.0f;
    private float lastSpawnTime = 0.0f;

    [Header("Audio")]
    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip sfx;

    private void Start()
    {
        canSpawn = false;
    }

    public void EnableSpawner()
    {
        canSpawn = true;
        StartCoroutine(DisableSpawner());
    }

    public IEnumerator DisableSpawner()
    {
        yield return new WaitForSeconds(15);
        canSpawn = false;
        barrier.SetActive(false);
    }

    public void SpawnEnemy()
    {
        if (canSpawn)
        {
            if (enemy.GetComponent<EnemyAi>())
            {
                if (src != null)
                {
                    src.clip = sfx;
                    src.Play();
                }

                lastSpawnTime = Time.time;
                GameObject newEnemy = Instantiate(enemy);
                newEnemy.transform.position = transform.position;
                newEnemy.transform.rotation = transform.rotation;
            }
        }
    }

    void Update()
    {
        if (Time.time - lastSpawnTime >= spawnTime)
        {
            SpawnEnemy();
        }
    }
}
