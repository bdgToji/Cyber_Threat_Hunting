using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    [SerializeField] public GameObject item;

    public GameObject DropItem()
    {
        return item;
    }

    public void SetItem(GameObject item)
    {
        this.item = item;
    }
}
