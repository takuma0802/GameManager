using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Battle.Inputs;

namespace Game.Battle.Players
{
    public abstract class BasePlayerComponent : MonoBehaviour
    {
        private IInputEventProvider _inputEventProvider;
        protected IInputEventProvider InputEventProvider { get { return _inputEventProvider; } }

        protected abstract void OnInitialize();

        void Start()
        {
            _inputEventProvider = GetComponent<IInputEventProvider>();
            OnInitialize();
        }
    }
}