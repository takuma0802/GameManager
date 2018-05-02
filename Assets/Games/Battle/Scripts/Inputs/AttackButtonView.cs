using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Game.Battle.Inputs
{
    public class AttackButtonView : MonoBehaviour
    {
        private Button _attackButton;
        public Button AttackButon { get { return _attackButton; } }

        void Awake()
        {
            _attackButton = GetComponent<Button>();
        }
    }
}
