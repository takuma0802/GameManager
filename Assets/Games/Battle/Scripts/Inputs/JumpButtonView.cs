using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Game.Battle.Inputs
{
    public class JumpButtonView : MonoBehaviour
    {
        private Button _jumpButton;
        public Button JumpButon { get { return _jumpButton; } }

        void Awake()
        {
            _jumpButton = GetComponent<Button>();
        }
    }
}
