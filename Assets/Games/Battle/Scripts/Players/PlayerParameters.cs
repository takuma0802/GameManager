using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Battle.Players
{
	public enum PlayerId
	{
		Player1 = 1,
		Player2 = 2,
		Player3 = 3,
		Player4 = 4,
		Player5 = 5,
		Player6 = 6,
		Player7 = 7,
		Player8 = 8
	}

    public struct PlayerParameters
    {
		public float HitPoint;
        public float MoveSpeed;
        public float DifencePower;
        public float AttackPower;
        public float AttackFrequency;
        public float JumpPower;
	}
}
