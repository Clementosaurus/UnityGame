using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text text;
    private PlayerControls player;

    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<PlayerControls>();
    }

    void Update()
    {
        text.text = "Coins : " + player.coins;
    }
}