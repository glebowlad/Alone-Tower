using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    int gamesPlayed = 1;
    public void Restart()
    {
        gamesPlayed++;
        if(gamesPlayed ==2)
        AdsManager.Instance.interstitialAds.ShowInterstitialAd();
        SceneManager.LoadScene(0);
    }
}
