using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private PlayerControls player;
    public Transform start;
    public GameObject explode;
    public InterstitialAds ad;

    void Start()
    {
        player = FindObjectOfType<PlayerControls>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("respawndelay");
            ad.RequestInterstitial();
        }
    }

    public IEnumerator respawndelay()
    {
        Instantiate(explode, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1);
        player.transform.position = start.position;
        player.GetComponent<Renderer>().enabled = true;
        player.enabled = true;
    }
}
