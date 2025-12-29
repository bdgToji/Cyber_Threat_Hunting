using UnityEngine;

public class AnswerLocationManager : MonoBehaviour
{
    [Header("Text Answers")]
    [SerializeField] private GameObject answer1;
    [SerializeField] private GameObject answer2;
    [SerializeField] private GameObject answer3;
    [SerializeField] private GameObject answer4;
    [SerializeField] private GameObject answer5;
    [SerializeField] private GameObject answer6;
    [SerializeField] private GameObject answer7;
    [SerializeField] private GameObject answer8;

    [Header("Object Answers")]
    [SerializeField] private GameObject a4Box;
    [SerializeField] private GameObject a8Box;

    [Header("ItemDrop object")]
    [SerializeField] private ItemDrop itemDrop;

    private Vector3 a1Location= new Vector3(-44.8699989f, 0.549000025f, 31.7399998f);
    private Vector3 a2Location= new Vector3(-47.137001f, 0.549000025f, 31.7399998f);
    private Vector3 a3Location = new Vector3(-46.0099983f, 0.549000025f, 16.9400005f);
    private Vector3 a4Location = new Vector3(-19.6599998f, 0.549000025f, 21.0599995f);
    private Vector3 a5Location = new Vector3(18.7999992f, 0.549000025f, 35.8499985f);
    private Vector3 a6Location = new Vector3(6.67999983f, 0.549000025f, 36.5099983f);
    private Vector3 a7Location = new Vector3(12.6400003f, 0.549000025f, 42.3600006f);


    private void Awake()
    {
        //SetFirstAndSecond();
        //SetThirdAndForth();
        SetFirstSecondThird();
        SetForthEight();
        SetRemaining();
    }

    private void SetFirstSecondThird()
    {
        int rng = Random.Range(1, 7);
        if (rng == 1)
        {
            answer1.transform.position = a1Location;
            answer2.transform.position = a2Location;
            answer3.transform.position = a3Location;
        }
        else if (rng == 2)
        {
            answer1.transform.position = a2Location;
            answer2.transform.position = a1Location;
            answer3.transform.position = a3Location;
        }
        else if (rng == 3)
        {
            answer1.transform.position = a1Location;
            answer2.transform.position = a3Location;
            answer3.transform.position = a2Location;
        }
        else if (rng == 4)
        {
            answer1.transform.position = a2Location;
            answer2.transform.position = a3Location;
            answer3.transform.position = a1Location;
        }
        else if (rng == 5)
        {
            answer1.transform.position = a3Location;
            answer2.transform.position = a1Location;
            answer3.transform.position = a2Location;
        }
        else if (rng == 6)
        {
            answer1.transform.position = a3Location;
            answer2.transform.position = a2Location;
            answer3.transform.position = a1Location;
        }
    }

    private void SetForthEight()
    {
        int rng = Random.Range(1, 3);
        if (rng == 1)
        {
            answer4.transform.position = a4Location;
            itemDrop.SetItem(a8Box);
        }
        else if (rng == 2)
        {
            itemDrop.SetItem(a4Box);
            answer8.transform.position = a4Location;
        }
    }

    /*private void SetFirstAndSecond()
    {

        int rng = Random.Range(1, 3);
        if (rng == 1)
        {
            answer1.transform.position = a1Location;
            answer2.transform.position = a2Location;
            Debug.Log("1 and 2 default");
        }
        else if (rng == 2)
        {
            answer1.transform.position = a2Location;
            answer2.transform.position = a1Location;
            Debug.Log("1 and 2 switched");
        }
    }

    private void SetThirdAndForth()
    {
        int rng = Random.Range(1, 3);
        if (rng == 1)
        {
            answer3.transform.position = a3Location;
            answer4.transform.position = a4Location;
            Debug.Log("3 and 4 default");
        }
        else if (rng == 2)
        {
            answer3.transform.position = a4Location;
            answer4.transform.position = a3Location;
            Debug.Log("3 and 4 switched");
        }
    }*/

    private void SetRemaining()
    {
        int rng = Random.Range(1, 7);
        if ( rng == 1)
        {
            answer5.transform.position = a5Location;
            answer6.transform.position = a6Location;
            answer7.transform.position = a7Location;
        }else if(rng == 2)
        {
            answer5.transform.position = a6Location;
            answer6.transform.position = a5Location;
            answer7.transform.position = a7Location;
        }
        else if (rng == 3)
        {
            answer5.transform.position = a5Location;
            answer6.transform.position = a7Location;
            answer7.transform.position = a6Location;
        }
        else if (rng == 4)
        {
            answer5.transform.position = a6Location;
            answer6.transform.position = a7Location;
            answer7.transform.position = a5Location;
        }
        else if (rng == 5)
        {
            answer5.transform.position = a7Location;
            answer6.transform.position = a5Location;
            answer7.transform.position = a6Location;
        }
        else if (rng == 6)
        {
            answer5.transform.position = a7Location;
            answer6.transform.position = a6Location;
            answer7.transform.position = a5Location;
        }
    }
}
