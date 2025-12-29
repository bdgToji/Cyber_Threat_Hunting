using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class QuestionModule : MonoBehaviour
{
    [SerializeField] private Transform spawnTransform;
    [SerializeField] private TMP_Text textAnswer;
    [SerializeField] private GameObject itemToGive;

    [Header("Sound")]
    [SerializeField] public SoundManager soundManager;
    [SerializeField] public AudioClip sfx;

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
        GameObject gObj = args.interactableObject.transform.gameObject;
        TMP_Text givenAnswer = gObj.GetComponentInChildren<TMP_Text>();
        if (givenAnswer.text == textAnswer.text )
        {
            soundManager.PlaySound(sfx);
            GameObject newItem = Instantiate(itemToGive);
            newItem.transform.position = spawnTransform.position;
            Destroy(gObj);
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
