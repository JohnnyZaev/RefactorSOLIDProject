﻿using UnityEngine;

public class NPCEnemy : NPC
{
    [SerializeField] private string text = "I deal 10 physical damage    ( •̀ᴗ•́ )و ̑̑ ";

    public override void Interact()
    {
        base.Interact();
        FindObjectOfType<Player>().ReceiveDamaged();
    }

    protected override string GetText()
    {
        return text;
    }
}
