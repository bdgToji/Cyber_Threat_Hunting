using UnityEngine;

public class GridTansformGroup : MonoBehaviour
{
    [SerializeField] private int columns;
    [SerializeField] private Vector2 cellSize;
    [SerializeField] private Vector2 cellSpace;

    private void ArrangeChildren()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            int row = i / columns;
            int col = i % columns;
            Vector3 childPosition = new(
                col * (cellSize.x + cellSpace.x),
                -row * (cellSize.y + cellSpace.y),
                0);
            child.localPosition = childPosition;
        }
    }

    void Start()
    {
        ArrangeChildren();
    }

    void Update()
    {

    }

    private void OnValidate()
    {
        ArrangeChildren();
    }

    private void OnTransformChildrenChanged()
    {
        ArrangeChildren();
    }
}
