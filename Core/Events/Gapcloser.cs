﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gapcloser.cs" company="LeagueSharp">
//   Copyright (C) 2015 LeagueSharp
//   
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//   
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <summary>
//   Detection of Gap-closers and fires the OnGapCloser event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace LeagueSharp.SDK.Core.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using LeagueSharp.SDK.Core.Enumerations;
    using LeagueSharp.SDK.Core.Extensions;

    using SharpDX;

    /// <summary>
    ///     Detection of Gap-closers and fires the OnGapCloser event.
    /// </summary>
    public class Gapcloser
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes static members of the <see cref="Gapcloser" /> class.
        ///     Static Constructor
        /// </summary>
        static Gapcloser()
        {
            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Aatrox", Slot = SpellSlot.Q, SpellName = "aatroxq", 
                        SkillType = GapcloserType.Skillshot
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Akali", Slot = SpellSlot.R, SpellName = "akalishadowdance", 
                        SkillType = GapcloserType.Targeted
                    });

            

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Alistar", Slot = SpellSlot.W, SpellName = "headbutt", 
                        SkillType = GapcloserType.Targeted
                    });

            

            #region Corki

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Corki", Slot = SpellSlot.W, SpellName = "carpetbomb", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Diana

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Diana", Slot = SpellSlot.R, SpellName = "dianateleport", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Elise

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Elise", Slot = SpellSlot.Q, SpellName = "elisespiderqcast", 
                        SkillType = GapcloserType.Skillshot
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Elise", Slot = SpellSlot.E, SpellName = "elisespideredescent", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Fiora

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Fiora", Slot = SpellSlot.Q, SpellName = "fioraq", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Fizz

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Fizz", Slot = SpellSlot.Q, SpellName = "fizzpiercingstrike", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Gnar

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Gnar", Slot = SpellSlot.E, SpellName = "gnarbige", 
                        SkillType = GapcloserType.Skillshot
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Gnar", Slot = SpellSlot.E, SpellName = "gnare", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Gragas

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Gragas", Slot = SpellSlot.E, SpellName = "gragase", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Graves

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Graves", Slot = SpellSlot.E, SpellName = "gravesmove", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Hecarim

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Hecarim", Slot = SpellSlot.R, SpellName = "hecarimult", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Irelia

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Irelia", Slot = SpellSlot.Q, SpellName = "ireliagatotsu", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region JarvanIV

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "JarvanIV", Slot = SpellSlot.Q, SpellName = "jarvanivdragonstrike", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Jax

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Jax", Slot = SpellSlot.Q, SpellName = "jaxleapstrike", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Jayce

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Jayce", Slot = SpellSlot.Q, SpellName = "jaycetotheskies", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Kassadin

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Kassadin", Slot = SpellSlot.R, SpellName = "riftwalk", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Khazix

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Khazix", Slot = SpellSlot.E, SpellName = "khazixe", 
                        SkillType = GapcloserType.Skillshot
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Khazix", Slot = SpellSlot.E, SpellName = "khazixelong", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region LeBlanc

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "LeBlanc", Slot = SpellSlot.W, SpellName = "leblancslide", 
                        SkillType = GapcloserType.Skillshot
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "LeBlanc", Slot = SpellSlot.R, SpellName = "leblancslidem", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region LeeSin

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "LeeSin", Slot = SpellSlot.Q, SpellName = "blindmonkqtwo", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Leona

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Leona", Slot = SpellSlot.E, SpellName = "leonazenithblade", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Lucian

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Lucian", Slot = SpellSlot.E, SpellName = "luciane", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Malphite

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Malphite", Slot = SpellSlot.R, SpellName = "ufslash", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region MasterYi

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "MasterYi", Slot = SpellSlot.Q, SpellName = "alphastrike", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region MonkeyKing

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "MonkeyKing", Slot = SpellSlot.E, SpellName = "monkeykingnimbus", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Pantheon

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Pantheon", Slot = SpellSlot.W, SpellName = "pantheon_leapbash", 
                        SkillType = GapcloserType.Targeted
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Pantheon", Slot = SpellSlot.R, SpellName = "pantheonrjump", 
                        SkillType = GapcloserType.Skillshot
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Pantheon", Slot = SpellSlot.R, SpellName = "pantheonrfall", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Poppy

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Poppy", Slot = SpellSlot.E, SpellName = "poppyheroiccharge", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Renekton

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Renekton", Slot = SpellSlot.E, SpellName = "renektonsliceanddice", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Riven

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Riven", Slot = SpellSlot.Q, SpellName = "riventricleave", 
                        SkillType = GapcloserType.Skillshot
                    });

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Riven", Slot = SpellSlot.E, SpellName = "rivenfeint", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Sejuani

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Sejuani", Slot = SpellSlot.Q, SpellName = "sejuaniarcticassault", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Shen

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Shen", Slot = SpellSlot.E, SpellName = "shenshadowdash", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Shyvana

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Shyvana", Slot = SpellSlot.R, SpellName = "shyvanatransformcast", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Talon

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Talon", Slot = SpellSlot.E, SpellName = "taloncutthroat", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Tristana

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Tristana", Slot = SpellSlot.W, SpellName = "rocketjump", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Tryndamere

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Tryndamere", Slot = SpellSlot.E, SpellName = "slashcast", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Vi

            Spells.Add(
                new GapCloser
                    {
                       ChampionName = "Vi", Slot = SpellSlot.Q, SpellName = "viq", SkillType = GapcloserType.Skillshot 
                    });

            #endregion

            #region XinZhao

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "XinZhao", Slot = SpellSlot.E, SpellName = "xenzhaosweep", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Yasuo

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Yasuo", Slot = SpellSlot.E, SpellName = "yasuodashwrapper", 
                        SkillType = GapcloserType.Targeted
                    });

            #endregion

            #region Zac

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Zac", Slot = SpellSlot.E, SpellName = "zace", SkillType = GapcloserType.Skillshot
                    });

            #endregion

            #region Ziggs

            Spells.Add(
                new GapCloser
                    {
                        ChampionName = "Ziggs", Slot = SpellSlot.W, SpellName = "ziggswtoggle", 
                        SkillType = GapcloserType.Skillshot
                    });

            #endregion

            Game.OnUpdate += Game_OnUpdate;
            Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast;
        }

        #endregion

        #region Delegates

        /// <summary>
        ///     OnGapCloser Delegate.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">GapCloserEvent Arguments Container</param>
        public delegate void OnGapCloserDelegate(object sender, GapCloserEventArgs e);

        #endregion

        #region Public Events

        /// <summary>
        ///     OnGapCloser Event.
        /// </summary>
        public static event OnGapCloserDelegate OnGapCloser;

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the active spells.
        /// </summary>
        public static List<GapCloserEventArgs> ActiveSpells { get; set; }

        /// <summary>
        ///     Gets or sets the spells.
        /// </summary>
        public static List<GapCloser> Spells { get; set; }

        #endregion

        #region Methods

        /// <summary>
        ///     On game tick update subscribed event function.
        /// </summary>
        /// <param name="args">
        ///     <see cref="System.EventArgs" /> containing event data
        /// </param>
        private static void Game_OnUpdate(EventArgs args)
        {
            ActiveSpells.RemoveAll(entry => Variables.TickCount > entry.TickCount + 900);
            if (OnGapCloser == null)
            {
                return;
            }

            foreach (var gapcloser in
                ActiveSpells.Where(gapcloser => gapcloser.Sender.IsValidTarget())
                    .Where(
                        gapcloser =>
                        gapcloser.SkillType == GapcloserType.Targeted
                        || (gapcloser.SkillType == GapcloserType.Skillshot
                            && ObjectManager.Player.DistanceSquared(gapcloser.Sender) < 250000)))
            {
                // 500 * 500
                OnGapCloser(MethodBase.GetCurrentMethod().DeclaringType, gapcloser);
            }
        }

        /// <summary>
        ///     On Process Spell Cast subscribed event function
        /// </summary>
        /// <param name="sender"><see cref="Obj_AI_Base" /> sender</param>
        /// <param name="args">Process Spell Cast Data</param>
        private static void Obj_AI_Base_OnProcessSpellCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (Spells.All(spell => spell.SpellName != args.SData.Name.ToLower()))
            {
                return;
            }

            ActiveSpells.Add(
                new GapCloserEventArgs
                    {
                        Start = args.Start, End = args.End, Sender = (Obj_AI_Hero)sender, TickCount = Variables.TickCount, 
                        SkillType =
                            (args.Target != null && args.Target.IsMe) ? GapcloserType.Targeted : GapcloserType.Skillshot, 
                        Slot = ((Obj_AI_Hero)sender).GetSpellSlot(args.SData.Name), 
                        IsDirectedToPlayer =
                            ObjectManager.Player.Distance(args.End) < ObjectManager.Player.Distance(args.Start)
                            || sender.IsFacing(ObjectManager.Player), 
                        SpellName = args.SData.Name
                    });
        }

        #endregion

        /// <summary>
        ///     GapCloser Data Container
        /// </summary>
        public struct GapCloser
        {
            #region Fields

            /// <summary>
            ///     Champion Name
            /// </summary>
            public string ChampionName;

            /// <summary>
            ///     Spell Type
            /// </summary>
            public GapcloserType SkillType;

            /// <summary>
            ///     Spell Slot
            /// </summary>
            public SpellSlot Slot;

            /// <summary>
            ///     Spell Name
            /// </summary>
            public string SpellName;

            #endregion
        }

        /// <summary>
        ///     GapCloser Data Container
        /// </summary>
        public class GapCloserEventArgs : EventArgs
        {
            #region Public Properties

            /// <summary>
            ///     Gets or sets the end.
            /// </summary>
            public Vector3 End { get; set; }

            /// <summary>
            ///     Gets or sets a value indicating whether is directed to player.
            /// </summary>
            public bool IsDirectedToPlayer { get; set; }

            /// <summary>
            ///     Gets or sets the sender.
            /// </summary>
            public Obj_AI_Hero Sender { get; set; }

            /// <summary>
            ///     Gets or sets the skill type.
            /// </summary>
            public GapcloserType SkillType { get; set; }

            /// <summary>
            ///     Gets or sets the slot.
            /// </summary>
            public SpellSlot Slot { get; set; }

            /// <summary>
            ///     Gets or sets the spell name.
            /// </summary>
            public string SpellName { get; set; }

            /// <summary>
            ///     Gets or sets the start.
            /// </summary>
            public Vector3 Start { get; set; }

            /// <summary>
            ///     Gets or sets the tick count.
            /// </summary>
            public int TickCount { get; set; }

            #endregion
        }
    }
}