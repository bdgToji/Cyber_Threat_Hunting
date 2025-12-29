using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPManager : MonoBehaviour
{
    [SerializeField] private HPBar[] hPBars;
    [SerializeField] private List<HPBar> hpList;
    [SerializeField] private GameObject empty;

    [SerializeField] private int currentHp = 3;

    private void Awake()
    {
        hPBars = empty.GetComponentsInChildren<HPBar>();
        for (int i = 0; i < hPBars.Length; i++)
        {
            hpList.Add(hPBars[i]);
        }
    }

    public void RemoveHPBar()
    {
        if (currentHp > 1)
        {
            currentHp--;
            HPBar hpBar = hpList.Last();
            hpList.Remove(hpBar);
            Destroy(hpBar.gameObject);
        }
        else
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyAi>() || other.GetComponent<Projectile>())
        {
            Debug.Log("Player damaged");
            RemoveHPBar();
            Destroy(other.gameObject);
        }
    }
}
