using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;

namespace Game.Battle.Inputs
{
    public class MoveDirectionView : MonoBehaviour
    {
        private RectTransform _rectTransform;
        public RectTransform RectTransform { get { return _rectTransform; } }
        private ObservableEventTrigger _moveDirection;
        public ObservableEventTrigger MoveDirection { get { return _moveDirection; } }


        void Awake()
        {
            RectTransform _rectTransform = transform.root.gameObject.GetComponent<RectTransform>();
            _moveDirection = gameObject.AddComponent<ObservableEventTrigger>();
        }
    }
}