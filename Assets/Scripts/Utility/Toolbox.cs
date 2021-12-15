using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Sound;
using DialogueSystem.Demo;

namespace Utility
{
    public sealed class Toolbox
    {
        private static readonly Lazy<Toolbox> lazy =
            new Lazy<Toolbox>(() => new Toolbox());
        /// <summary>
        /// The singleton instance of the Toolbox
        /// </summary>
        public static Toolbox Instance { get { return lazy.Value; } }
        /// <summary>
        /// The repository for all the sound in the game.
        /// </summary>
        public SoundRepository SoundPool { get; private set; }
        /// <summary>
        /// The pausing interface. The gameobject must be present in the scene!
        /// </summary>
        public Pause Pause { get; set; }
        public BackgroundDatabase Backgrounds { get; private set; }
        public Background bg { get; set; }
        public DialogueController dialogue { get; set; }

        private Toolbox()
        {
            SoundPool = new SoundRepository();
            Backgrounds = new BackgroundDatabase();
        }
    }
}