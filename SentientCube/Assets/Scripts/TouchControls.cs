using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private PlayerControls player;

    void Start()
    {
        player = FindObjectOfType<PlayerControls>();
    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
    }

    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
    }

    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }

    public void ReleaseRightArrow()
    {
        player.moveright = false;

    }

    public void Jump()
    {
        player.jump = true;
    }
}