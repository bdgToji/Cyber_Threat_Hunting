using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TerminalModule : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject databaseImage;
    [SerializeField] private GameObject loginForm;
    [SerializeField] private TMP_Text userText;
    [SerializeField] private GameObject terminateText;
    [SerializeField] private GameObject skullBtn;
    private XRSocketInteractor socketInteractor;

    private void Awake()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();

        socketInteractor.selectEntered.AddListener(EnterUrl);
        socketInteractor.selectExited.AddListener(RemoveUrl);
    }

    private void OnDestroy()
    {
        socketInteractor.selectEntered.RemoveListener(EnterUrl);
        socketInteractor.selectExited.RemoveListener(RemoveUrl);
    }

    public void EnterUrl(SelectEnterEventArgs args)
    {
        GameObject givenUrl = args.interactableObject.transform.gameObject;
        if (givenUrl.GetComponent<URLCube>())
        {
            text.text = "URL ENTERED!";
            //databaseImage.SetActive(true);
            loginForm.SetActive(true);
        }
    }

    public void RemoveUrl(SelectExitEventArgs args)
    {
        GameObject givenUrl = args.interactableObject.transform.gameObject;
        if (givenUrl.GetComponent<URLCube>())
        {
            text.text = "";
            //databaseImage.SetActive(false);
            loginForm.SetActive(false);
        }
    }

    public void OnButtonPress()
    {
        terminateText.SetActive(true);
        skullBtn.SetActive(true);
    }

    public void TerminateDatabase()
    {
        Debug.Log("You win!");
        SceneManager.LoadScene("WinScene");
    }

    public void AttachSQL(SelectEnterEventArgs args)
    {
        if (loginForm.activeSelf && args.interactableObject.transform.gameObject.GetComponent<SQLInjection>())
        {
            databaseImage.SetActive(true);
            userText.text = "administrator'-- ";
        }
    }

    public void RemoveSQL(SelectExitEventArgs args)
    {
        databaseImage.SetActive(false);
    }
}
