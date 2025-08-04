using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InitializeAds : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string androidId;
    [SerializeField] private bool isTesting;
    private string gameId;

    public void OnInitializationComplete()
    {
        Debug.Log("Ads initialized");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message){}

    private void Awake()
    {
    #if UNITY_ANDROID
        gameId = androidId;
#elif UNITY_EDITOR
        gameid=androidId;
#endif
        if (!Advertisement.isInitialized && Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, isTesting, this);
        }
    }
}
