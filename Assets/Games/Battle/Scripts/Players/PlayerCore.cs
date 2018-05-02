using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Game.Battle.Attacks;
using Game.Battle.Damages;
using Game.Battle.GameManagers;

namespace Game.Battle.Players
{

    public class PlayerCore : MonoBehaviour , IDamageApplicable
    {
        private PlayerId playerId;
        public PlayerId PlayerId { get { return playerId; } }
        private IAttacker latestDamageAttacker;
        public IAttacker LatestDamageAttacker { get { return latestDamageAttacker; } }
        private ReactiveProperty<bool> _isAlive = new BoolReactiveProperty(true);
        public IReadOnlyReactiveProperty<bool> IsAlive { get { return _isAlive; } }

        private IGameStateReadable _gameStateReadable;
        public IReadOnlyReactiveProperty<GameState> CurrentGameState { get { return _gameStateReadable.GameState; } }

        private readonly AsyncSubject<PlayerId> _onInithilized = new AsyncSubject<PlayerId>();
        public IObservable<PlayerId> OnInithilized { get { return _onInithilized; } }

        private PlayerParameters startParameter;
        private ReactiveProperty<PlayerParameters> currentParameter;

        public PlayerCore(PlayerId id)
        {
            playerId = id;
        }




        public void ResetPlayerParameters()
        {
            currentParameter.Value = startParameter;
        }

        public void SetPlayerParameters(PlayerParameters parameters)
        {
            currentParameter.Value = parameters;
        }

        public void ApplyDamage(Damage damage)
        {

        }




    }
}
