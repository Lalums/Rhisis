﻿using Rhisis.Core.Common.Formulas;
using Rhisis.Core.Data;
using Rhisis.World.Game.Entities;
using System;

namespace Rhisis.World.Game.Helpers
{
    /// <summary>
    /// Contains helper methods to manage a player.
    /// </summary>
    public static class PlayerHelper
    {
        /// <summary>
        /// Gets the player's max origin HP.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <returns>Max Origin HP.</returns>
        public static int GetMaxOriginHp(IPlayerEntity player)
        {
            return HealthFormulas.GetMaxOriginHp(
                player.Object.Level, 
                player.Attributes[DefineAttributes.STA], 
                player.PlayerData.JobData.MaxHpFactor);
        }

        /// <summary>
        /// Gets the player's max origin MP.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <returns>Max Origin MP.</returns>
        public static int GetMaxOriginMp(IPlayerEntity player)
        {
            return HealthFormulas.GetMaxOriginMp(
                player.Object.Level,
                player.Attributes[DefineAttributes.INT],
                player.PlayerData.JobData.MaxMpFactor,
                true);
        }

        /// <summary>
        /// Gets the player's max origin FP.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <returns>Max Oiring FP.</returns>
        public static int GetMaxOriginFp(IPlayerEntity player)
        {
            return HealthFormulas.GetMaxOriginFp(player.Object.Level,
                player.Attributes[DefineAttributes.STA],
                player.Attributes[DefineAttributes.DEX],
                player.Attributes[DefineAttributes.STR],
                player.PlayerData.JobData.MaxFpFactor,
                true);
        }

        /// <summary>
        /// Gets the player's max HP.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <returns>Max HP.</returns>
        public static int GetMaxHP(IPlayerEntity player)
        {
            return GetMaxParamPoints(GetMaxOriginHp(player), 
                player.Attributes[DefineAttributes.HP_MAX], 
                player.Attributes[DefineAttributes.HP_MAX_RATE]);
        }

        /// <summary>
        /// Gets the player's max MP.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <returns>Max MP.</returns>
        public static int GetMaxMP(IPlayerEntity player)
        {
            return GetMaxParamPoints(GetMaxOriginMp(player),
                player.Attributes[DefineAttributes.MP_MAX],
                player.Attributes[DefineAttributes.MP_MAX_RATE]);
        }

        /// <summary>
        /// Gets the player's max FP.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <returns>Max FP.</returns>
        public static int GetMaxFP(IPlayerEntity player)
        {
            return GetMaxParamPoints(GetMaxOriginFp(player),
                player.Attributes[DefineAttributes.FP_MAX],
                player.Attributes[DefineAttributes.FP_MAX_RATE]);
        }

        /// <summary>
        /// Gets the correct player's point based on an attribute.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <param name="attribute">Attribute</param>
        /// <returns>Points based on the given attribute.</returns>
        public static int GetPoints(IPlayerEntity player, DefineAttributes attribute)
        {
            switch (attribute)
            {
                case DefineAttributes.HP: return player.Health.Hp + player.Attributes[DefineAttributes.HP];
                case DefineAttributes.MP: return player.Health.Mp + player.Attributes[DefineAttributes.MP];
                case DefineAttributes.FP: return player.Health.Fp + player.Attributes[DefineAttributes.FP];
                default: return -1;
            }
        }

        /// <summary>
        /// Sets the player's points.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <param name="attribute">Attribute to set.</param>
        /// <param name="value">New value to set.</param>
        public static void SetPoints(IPlayerEntity player, DefineAttributes attribute, int value)
        {
            int max = GetMaxPoints(player, attribute);
            int current = GetPoints(player, attribute);

            if (current == value)
                return;

            switch (attribute)
            {
                case DefineAttributes.HP: player.Health.Hp = Math.Min(value, max); break;
                case DefineAttributes.MP: player.Health.Mp = Math.Min(value, max); break;
                case DefineAttributes.FP: player.Health.Fp = Math.Min(value, max); break;
            }
        }

        /// <summary>
        /// Gets the correct player's max points based on an attribute.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <param name="attribute">Attribute.</param>
        /// <returns>Max points based on the given attribute.</returns>
        public static int GetMaxPoints(IPlayerEntity player, DefineAttributes attribute)
        {
            switch (attribute)
            {
                case DefineAttributes.HP: return GetMaxHP(player);
                case DefineAttributes.MP: return GetMaxMP(player);
                case DefineAttributes.FP: return GetMaxFP(player);
                default: return -1;
            }
        }

        /// <summary>
        /// Calculates the max parameter points.
        /// </summary>
        /// <param name="originValue">Original value.</param>
        /// <param name="additonnal">Additionnal value.</param>
        /// <param name="maxFactor">Max factor.</param>
        /// <returns>Max param points.</returns>
        private static int GetMaxParamPoints(int originValue, int additonnal, int maxFactor)
        {
            int maxHp = originValue + additonnal;

            float factor = 1f + (maxFactor / 100f);

            maxHp = Math.Max((int)(maxHp * factor), 1);

            return maxHp;
        }
    }
}
