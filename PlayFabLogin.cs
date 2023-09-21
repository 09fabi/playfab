using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;

public class PlayFabLogin : MonoBehaviour
{

    // Definimos variables de objeto para InputField
    public InputField inp_email;
    public InputField inp_password;

    public void Start()
    {
        //var request = new LoginWithCustomIDRequest { CustomId = "easykid", CreateAccount = true};
        //PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
        //LoginEmail();
    }

    public void LoginEmail()
    {
        //Variables de tipo string para almacenar el email y clave
        string user_email = inp_email.text;
        string user_password = inp_password.text;

        var request = new LoginWithEmailAddressRequest { Email = user_email, Password = user_password};
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("********* LOGIN OK ***********");
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning(" --- ERROR EN LOGIN --- ");
        Debug.LogError(error.GenerateErrorReport());
    }
}