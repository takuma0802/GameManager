using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using Game.Battle.Players;

namespace Game.Battle.Inputs
{
    public class TouchInputEventProvider : BasePlayerComponent, IInputEventProvider
    {
        // View
        [SerializeField] private JumpButtonView jumpButton;
        [SerializeField] private AttackButtonView attackButton;
        [SerializeField] private DashButtonView dashButton;
        [SerializeField] private MoveDirectionView moveDirectionTrigger;

        private ReactiveProperty<bool> _jump = new BoolReactiveProperty(false);
        private ReactiveProperty<bool> _attack = new BoolReactiveProperty(false);
        private ReactiveProperty<bool> _dash = new BoolReactiveProperty(false);
        private ReactiveProperty<Vector3> _moveDirection = new ReactiveProperty<Vector3>();

        public IReadOnlyReactiveProperty<bool> Jump { get { return _jump; } }
        public IReadOnlyReactiveProperty<bool> Attack { get { return _attack; } }
        public IReadOnlyReactiveProperty<bool> Dash { get { return _dash; } }
        public IReadOnlyReactiveProperty<Vector3> MoveDirection { get { return _moveDirection; } }

        protected override void OnInitialize()
        {
            // Drag処理のストリーム発行
            Vector2 tmpPosition = Vector2.zero;
            Vector2 startPostion = Vector2.zero;

            moveDirectionTrigger.MoveDirection
            .OnBeginDragAsObservable()
            .Select(_ => Input.mousePosition)
            .Select(mousePos => {
                tmpPosition = RectTransformUtility.WorldToScreenPoint(Camera.main,mousePos);
                return tmpPosition;
            })
            .Subscribe(position => startPostion = position);

            moveDirectionTrigger.MoveDirection
            .OnDragAsObservable()
            .Select(_ => Input.mousePosition)
            .Select(mousePos => {
                tmpPosition = RectTransformUtility.WorldToScreenPoint(Camera.main,mousePos);
                return tmpPosition - startPostion;
            })
            .Select(position => new Vector3(position.x,0,position.y))
            .Subscribe(x => _moveDirection.SetValueAndForceNotify(x));
            
            moveDirectionTrigger.MoveDirection
            .OnEndDragAsObservable()
            .Subscribe(_ =>  startPostion = Vector2.zero);


            // Button処理のストリーム発行
            jumpButton.JumpButon
            .OnClickAsObservable()
            .DistinctUntilChanged()
            .Subscribe(_ => {
                _jump.Value = !_jump.Value;
            });

            attackButton.AttackButon
            .OnClickAsObservable()
            .DistinctUntilChanged()
            .Subscribe(x => _attack.Value = !_attack.Value);

            dashButton.DashButon
            .OnClickAsObservable()
            .DistinctUntilChanged()
            .Subscribe(x => _dash.Value = !_dash.Value);
        }
    }
}
