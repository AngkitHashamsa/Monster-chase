using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 temPos;
    private string PLAYER_TAG = "Player";
    [SerializeField]
    private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag(PLAYER_TAG).transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
        {
            return;
        }

        temPos = transform.position;
        temPos.x = player.position.x;
        if (temPos.x < minX)
        {
            temPos.x = minX;
        }
        if (temPos.x > maxX)
        {
            temPos.x = maxX;
        }

        transform.position = temPos;
    }
}
