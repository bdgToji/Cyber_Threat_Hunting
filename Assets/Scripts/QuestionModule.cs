using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class QuestionModule : MonoBehaviour
{
    [SerializeField] private Transform spawnTransform;
    [SerializeField] private GameObject answer;
    [SerializeField] private GameObject itemToGive;

    private XRSocketInteractor socketInteractor;

    private void Awake()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
        if( socketInteractor == null)
        {
            socketInteractor = gameObject.AddComponent<XRSocketInteractor>();
        }

        socketInteractor.selectEntered.AddListener(AddAnswer);
    }

    private void OnDestroy()
    {
        socketInteractor.selectEntered.RemoveListener(AddAnswer);
    }

    private void AddAnswer(SelectEnterEventArgs args)
    {
        GameObject givenAwnser = args.interactableObject.transform.gameObject;
        if ( givenAwnser == answer )
        {
            GameObject newItem = Instantiate(itemToGive);
            newItem.transform.position = spawnTransform.position;
            Destroy(givenAwnser);
        }

        /*answer = args.interactableObject.transform.gameObject;
        AnswerA answerA = answer.GetComponent<AnswerA>();
        if ( answerA != null )
        {
            GameObject newItem = Instantiate(itemToGive);
            newItem.transform.position = spawnTransform.position;
            Destroy(answer);
        }*/
    }
}
