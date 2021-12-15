using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Snow_DialogueCode : DialogueCode, IDialogueCode
    {
        public Snow_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 8a6cdf7f-f0de-4ca1-9baa-b04dd3ab967f //
DialogueSystem.Demo.DialogueController dc = Utility.Toolbox.Instance.dialogue;
Background bg = Utility.Toolbox.Instance.bg;
string n = "Narrator";


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Snow_c7cd57fb3b4a49b1bdb65dfb02db8f43_bb30c90c7a1e4b06afeb282f6b76dcb6",Snow_c7cd57fb3b4a49b1bdb65dfb02db8f43_bb30c90c7a1e4b06afeb282f6b76dcb6);

        }

        // Dialogue Checks //
        // From Node: c7cd57fb-3b4a-49b1-bdb6-5dfb02db8f43 //
        // Choice: “Who was hopscotching here?” - bb30c90c-7a1e-4b06-afeb-282f6b76dcb6 //
        public bool Snow_c7cd57fb3b4a49b1bdb65dfb02db8f43_bb30c90c7a1e4b06afeb282f6b76dcb6()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //

    }
}
