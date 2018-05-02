using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Game.Battle.Inputs
{
    public class DashButtonView : MonoBehaviour
    {
        private Button _dashButton;
        public Button DashButon { get { return _dashButton; } }

        void Awake()
        {
            _dashButton = GetComponent<Button>();
        }
    }
}
