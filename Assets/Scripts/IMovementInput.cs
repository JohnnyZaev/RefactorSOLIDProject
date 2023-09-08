using System;
using UnityEngine;

public interface IMovementInput
{
    public Vector2 MovementInputVector { get; }
    public event Action OnInteractEvent;
}
