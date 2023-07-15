using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public const string FOLLOWS_Y_PREF = "player.cameraFollowsY";

    public GameObject target;

    public float minY = 0;

    public float xOffset, yOffset, zOffset;

    public float followingYOffset = -1;

    private bool followY = false;

    void Start()
    {
        followY = PlayerPrefs.GetInt(FOLLOWS_Y_PREF, 0) != 0;
        if (followY && followingYOffset != -1) yOffset = followingYOffset;

        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position);
    }

    void Update()
    {
        var tpos = target.transform.position;
        transform.position = new Vector3(
            tpos.x + xOffset,
            followY
                ? Mathf.Max(minY, Mathf.Lerp(transform.position.y, tpos.y + yOffset, .05f))
                : transform.position.y,
            tpos.z + zOffset
        );
    }
}
