using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Game.Battle.GameManagers;

namespace Game.Battle.Players
{
    public interface IGameStateReadable
    {
        IReadOnlyReactiveProperty<GameState> GameState { get; }
    }
}
