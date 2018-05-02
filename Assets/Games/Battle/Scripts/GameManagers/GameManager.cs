using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Battle.GameManagers
{
	public enum GameState
	{
		Initializing,
		Ready,
		Battle,
		Result,
		Finished
	}

    public class GameManager : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            
        }
    }
}
