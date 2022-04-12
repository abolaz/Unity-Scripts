using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class InternetConnection : MonoBehaviour
{
    [SerializeField] private bool connectionStatus;

    private void Start()
    {
        StartCoroutine(CheckConnection());
    }

    IEnumerator CheckConnection() 
    {
        UnityWebRequest request = new UnityWebRequest("https://www.google.com/");
        yield return request.SendWebRequest();

        setConnectionStatus(request.error == null);
    }

    private void setConnectionStatus(bool status) => connectionStatus = status;
}
