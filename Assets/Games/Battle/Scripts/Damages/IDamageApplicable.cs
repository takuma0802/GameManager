using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Battle.Damages
{
    public interface IDamageApplicable
    {
        void ApplyDamage(Damage damage);
    }
}
