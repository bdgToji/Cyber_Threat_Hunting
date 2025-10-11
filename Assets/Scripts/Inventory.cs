using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private bool isToggled;
    private Vector3 originalPosition;

    private void Awake()
    {
        isToggled = true;
        originalPosition = transform.localPosition;
    }

    public void Toggle()
    {
        isToggled = !isToggled;

        if (!isToggled)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 10, transform.localPosition.z);
        }
        else
        {
            transform.localPosition = originalPosition;
        }
    }
}
