﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Controller/Ability/Teleport")]
public class TeleportAbility : AbilityHandler
{
    private Rigidbody rb;
    public void Awake() {
        if(player == null)return;
        Debug.Log("teleport");
        rb = player.GetComponent<Rigidbody>();
        Vector3 moveVec = rb.transform.forward * 800;
        rb.MovePosition(rb.transform.position + moveVec);
        Instantiate(endParticle, player.transform);
    }

}
