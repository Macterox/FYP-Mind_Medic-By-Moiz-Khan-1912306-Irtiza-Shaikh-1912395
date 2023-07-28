using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SendToGoogle : MonoBehaviour
{
    public GameObject question;
    public GameObject email;
    public GameObject name;

    private string Question;
    private string Email;
    private string Name;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSf7V-SpHkhwyuHPyhMMLRNFt5UQdZI6P0weW8yMisBtzdeqFA/viewform?usp=sf_link";

    IEnumerator Post(string question, string email, string name)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1252782817", question);
        form.AddField("entry.1963290693", email);
        form.AddField("entry.1881026252", name);

        UnityWebRequest www = UnityWebRequest.Post(BASE_URL, form);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }

    public void Send()
    {
        Question = question.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Name = name.GetComponent<InputField>().text;
        StartCoroutine(Post(Question, Email, Name));
    }
}
