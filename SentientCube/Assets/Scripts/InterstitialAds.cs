using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InterstitialAds : MonoBehaviour
{
    private InterstitialAd interstitial;

    void Start()
    {
        this.RequestInterstitial();
    }


    void Update()
    {
        
    }

    public void RequestInterstitial()
    {
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";

        this.interstitial = new InterstitialAd(adUnitId);

        AdRequest request = new AdRequest.Builder().Build();

        this.interstitial.LoadAd(request);

        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
}
