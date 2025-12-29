using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyAi[] enemies;
    [SerializeField] private TurretAI[] turrets;

    [Header("Audio")]
    [SerializeField] public SoundManager soundManager;
    [SerializeField] public AudioClip sfx;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            soundManager.PlaySound(sfx);
            for (int i=0; i< enemies.Length; i++)
            {
                int rng = Random.Range(1, 3);
                if (rng == 1)
                {
                    enemies[i].gameObject.SetActive(true);
                }
                else if (rng == 2)
                {
                    turrets[i].gameObject.SetActive(true);
                }
            }
            gameObject.SetActive(false);
        }
    }
}
