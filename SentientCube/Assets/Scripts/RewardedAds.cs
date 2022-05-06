using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class RewardedAds : MonoBehaviour
{
    private RewardedAd rewardedAd;
    string adUnitId;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void RequestRewarded()
    {
        adUnitId = "ca-app-pub-3940256099942544/5224354917";

        this.rewardedAd = new RewardedAd(adUnitId);

        AdRequest request = new AdRequest.Builder().Build();

        this.rewardedAd.LoadAd(request);

        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }
}
