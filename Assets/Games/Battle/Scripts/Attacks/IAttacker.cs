using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Battle.Players;

namespace Game.Battle.Attacks
{
    public interface IAttacker
    {

    }

    public struct PlayerAttacker : IAttacker
    {
        public PlayerId PlayerId { get; private set; }

		public PlayerAttacker(PlayerId playerId) : this()
		{
			PlayerId = playerId;
		}
    }

	public struct NonPlayerAttacker : IAttacker
	{
		public static NonPlayerAttacker Default = new NonPlayerAttacker();
	}
}