﻿using Microsoft.Xna.Framework;

namespace Barotrauma
{
    class HumanWalkParams : HumanGroundedParams
    {
        public static HumanWalkParams GetDefaultAnimParams(Character character) => GetDefaultAnimParams<HumanWalkParams>(character.SpeciesName, AnimationType.Walk);
        public static HumanWalkParams GetAnimParams(Character character, string fileName = null)
        {
            return GetAnimParams<HumanWalkParams>(character.SpeciesName, AnimationType.Walk, fileName);
        }
    }

    class HumanRunParams : HumanGroundedParams
    {
        public static HumanRunParams GetDefaultAnimParams(Character character) => GetDefaultAnimParams<HumanRunParams>(character.SpeciesName, AnimationType.Run);
        public static HumanRunParams GetAnimParams(Character character, string fileName = null)
        {
            return GetAnimParams<HumanRunParams>(character.SpeciesName, AnimationType.Run, fileName);
        }
    }

    class HumanSwimFastParams: HumanSwimParams
    {
        public static HumanSwimFastParams GetDefaultAnimParams(Character character) => GetDefaultAnimParams<HumanSwimFastParams>(character.SpeciesName, AnimationType.SwimFast);
        public static HumanSwimFastParams GetAnimParams(Character character, string fileName = null)
        {
            return GetAnimParams<HumanSwimFastParams>(character.SpeciesName, AnimationType.SwimFast, fileName);
        }
    }

    class HumanSwimSlowParams : HumanSwimParams
    {
        public static HumanSwimSlowParams GetDefaultAnimParams(Character character) => GetDefaultAnimParams<HumanSwimSlowParams>(character.SpeciesName, AnimationType.SwimSlow);
        public static HumanSwimSlowParams GetAnimParams(Character character, string fileName = null)
        {
            return GetAnimParams<HumanSwimSlowParams>(character.SpeciesName, AnimationType.SwimSlow, fileName);
        }
    }

    abstract class HumanSwimParams : SwimParams
    {
        [Serialize(0.5f, true), Editable]
        public float LegMoveAmount { get; set; }

        [Serialize(5.0f, true), Editable]
        public float LegCycleLength { get; set; }

        [Serialize("0.5, 0.1", true), Editable]
        public Vector2 HandMoveAmount { get; set; }

        [Serialize(5.0f, true), Editable]
        public float HandCycleSpeed { get; set; }

        [Serialize("0.0, 0.0", true), Editable]
        public Vector2 HandMoveOffset { get; set; }
    }

    abstract class HumanGroundedParams : GroundedMovementParams
    {
        [Serialize(0.3f, true), Editable]
        public float GetUpSpeed { get; set; }
        
        [Serialize(0.65f, true), Editable]
        public float CrouchingTorsoPos { get; set; }

        /// <summary>
        /// In degrees
        /// </summary>
        [Serialize(-10f, true), Editable]
        public float CrouchingTorsoAngle { get; set; }

        [Serialize(0.25f, true), Editable]
        public float HeadLeanAmount { get; set; }

        [Serialize(0.25f, true), Editable]
        public float TorsoLeanAmount { get; set; }

        [Serialize(5.0f, true), Editable]
        public float CycleSpeed { get; set; }

        [Serialize(15.0f, true), Editable]
        public float FootMoveStrength { get; set; }

        [Serialize(20.0f, true), Editable]
        public float FootRotateStrength { get; set; }

        [Serialize("0.0, 0.0", true), Editable]
        public Vector2 FootMoveOffset { get; set; }

        [Serialize(10.0f, true), Editable]
        public float LegCorrectionTorque { get; set; }

        [Serialize("0.4, 0.15", true), Editable]
        public Vector2 HandMoveAmount { get; set; }

        [Serialize("-0.15, 0.0", true), Editable]
        public Vector2 HandMoveOffset { get; set; }

        [Serialize(0.7f, true), Editable]
        public float HandMoveStrength { get; set; }

        [Serialize(-1.0f, true), Editable]
        public float HandClampY { get; set; }
    }
}