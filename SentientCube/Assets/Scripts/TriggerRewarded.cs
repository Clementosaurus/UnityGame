using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRewarded : MonoBehaviour
{
    RewardedAds ad;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        ad = new RewardedAds();
        ad.RequestRewarded();
    }
}
