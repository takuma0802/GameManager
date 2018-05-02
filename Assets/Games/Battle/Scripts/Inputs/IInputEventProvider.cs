using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Game.Battle.Inputs
{
    public interface IInputEventProvider
    {
        IReadOnlyReactiveProperty<bool> Jump { get; }
        IReadOnlyReactiveProperty<bool> Attack { get; }
        IReadOnlyReactiveProperty<bool> Dash { get; }
        IReadOnlyReactiveProperty<Vector3> MoveDirection { get; }
    }
}
