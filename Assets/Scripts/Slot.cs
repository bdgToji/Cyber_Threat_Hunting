using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Slot : MonoBehaviour
{
    public GameObject ItemInSlot;
    [SerializeField] private XRSocketInteractor socketIneractor;

    private void Awake()
    {
        socketIneractor = GetComponent<XRSocketInteractor>();
        if (socketIneractor == null)
        {
            socketIneractor = gameObject.AddComponent<XRSocketInteractor>();
        }

        socketIneractor.selectEntered.AddListener(OnInsertItem);
        socketIneractor.selectExited.AddListener(OnRemoveItem);
    }

    private void OnDestroy()
    {
        socketIneractor.selectEntered.RemoveListener(OnInsertItem);
        socketIneractor.selectExited.RemoveListener(OnRemoveItem);
    }

    private void OnInsertItem(SelectEnterEventArgs args)
    {
        ItemInSlot = args.interactableObject.transform.gameObject;

        ItemInSlot.transform.localPosition = Vector3.zero;
        ItemInSlot.transform.localRotation = Quaternion.Euler(ItemInSlot.GetComponent<Item>().slotRotation);

        Rigidbody rb = ItemInSlot.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }

        Item item = ItemInSlot.GetComponent<Item>();
        if (item != null)
        {
            item.inSlot = true;
            item.currentSlot = this;
        }
    }

    private void OnRemoveItem(SelectExitEventArgs args)
    {
        ItemInSlot = null;

        Item item = args.interactableObject.transform.gameObject.GetComponent<Item>();
        Rigidbody rb = item.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = false;
        }
        if (item != null)
        {
            item.inSlot = false;
            item.currentSlot = null;
        }
    }
}
