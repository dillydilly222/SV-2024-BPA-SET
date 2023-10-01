using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP.FDG.Units
{
    [CreateAssetMenu(fileName = "New Unit", menuName = "New Unit/Basic")]
    public class BasicUnit : ScriptableObject
    {
        
        public enum unitType
        {
            Worker,
            Warrior,
            Healer
        };


        [Header("Unit Settings")]
        [Space(15)]
        public unitType type;

        public new string name;

        public GameObject humamnPrefab;
        public GameObject infectedPrefab;

        [Space(40)]
        [Header("Unit Base Stats")]
        [Space(15)]

        public UnitStatTypes.Base baseStats;
    }
}

