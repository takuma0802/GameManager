using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

namespace Game.Battle.Players
{
    public class PlayerCharacterController : BasePlayerComponent
    {
        private CharacterController cc;
        private Rigidbody _rigidbody;
        private Vector3 moveVelocity;

        void Awake()
        {
            cc = GetComponent<CharacterController>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move(Vector3 newVelocity)
        {
            moveVelocity = newVelocity;
        }

        public void Jump(float power)
        {
            _rigidbody.AddForce(Vector3.up * power);
        }

        protected override void OnInitialize()
        {
            this.FixedUpdateAsObservable()
            .Subscribe(_ => {
                _rigidbody.AddForce(moveVelocity,ForceMode.Acceleration);
            });
        } 
    }
}
