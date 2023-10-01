using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP.FDG.Buildings
{
    [CreateAssetMenu(fileName = "Building", menuName = "New Building/Basic")]
    public class BasicBuilding : ScriptableObject
    {
        public enum buildingType
        {
            Barracks
        }

        [Header("BuildingSettings")]
        [Space(15)]

        public buildingType type;
        public new string name;
        public GameObject buildingPrefab;
        public BuildingActions.BuildingUnits Units;

        [Space(40)]
        [Header("Building Base Stats")]
        [Space(15)]

        public BuildingStatTypes.Base baseStats;
    }
}
