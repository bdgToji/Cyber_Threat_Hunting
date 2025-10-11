using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.XR.CoreUtils;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    [SerializeField] private HPBar[] hPBars;
    [SerializeField] private List<HPBar> hpList;
    [SerializeField] private GameObject empty;

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
        if (hpList.Any())
        {
            HPBar hpBar = hpList.Last();
            hpList.Remove(hpBar);
            Destroy(hpBar.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyAi>())
        {
            Debug.Log("Playaer damaged");
            RemoveHPBar();
            Destroy(other.gameObject);
        }
    }
}
