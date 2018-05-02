using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Game.Battle.Players
{
    public class PlayerMover : BasePlayerComponent
    {
        protected override void OnInitialize()
        {
            var cc = GetComponent<PlayerCharacterController>();

            InputEventProvider.Jump
            .Subscribe(_ =>
            {
                cc.Jump(5);
            });

            InputEventProvider.Attack
            .Subscribe(_ =>
            {
                Debug.Log("Attack!");
            });

            InputEventProvider.Dash
            .Subscribe(_ =>
            {
                Debug.Log("Dash!");
            });

            InputEventProvider.MoveDirection
            .Subscribe(x =>
            {
                var value = x.normalized * 15f;
                cc.Move(value);
            });
        }
    }
}
