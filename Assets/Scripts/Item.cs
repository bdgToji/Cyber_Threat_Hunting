using UnityEngine;

public class Item : MonoBehaviour
{
    public bool inSlot;
    [SerializeField] public Vector3 slotRotation = Vector3.zero;
    public Slot currentSlot;
}
