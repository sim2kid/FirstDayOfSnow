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
DialogueSystem.Demo.DialogueController dc;
Background bg;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Snow_c7cd57fb3b4a49b1bdb65dfb02db8f43_bb30c90c7a1e4b06afeb282f6b76dcb6",Snow_c7cd57fb3b4a49b1bdb65dfb02db8f43_bb30c90c7a1e4b06afeb282f6b76dcb6);
            dialogueChecks.Add("Snow_1cddfc8aa7af4f509d9a01176c740275_6b27e12af32d4a22bd92e809a99b28ec",Snow_1cddfc8aa7af4f509d9a01176c740275_6b27e12af32d4a22bd92e809a99b28ec);
            eventFunctions.Add("Snow_df6ee159d7e34f6785edbc1a0e507d4a",Snow_df6ee159d7e34f6785edbc1a0e507d4a);
            eventFunctions.Add("Snow_2ff9b85e82474ce19baa76936205f3d2",Snow_2ff9b85e82474ce19baa76936205f3d2);
            dialogueChecks.Add("Snow_7343df012e6749a5a5e8be25bf2f2352_af5e39f2d39449ccbc4bcefe7403e025",Snow_7343df012e6749a5a5e8be25bf2f2352_af5e39f2d39449ccbc4bcefe7403e025);
            eventFunctions.Add("Snow_f821bc2c4317403daef0217b41e19801",Snow_f821bc2c4317403daef0217b41e19801);
            dialogueChecks.Add("Snow_c9397c59a59941a59512f0f6ea953b2d_3e74a4a99eba452da8d53a864fed508b",Snow_c9397c59a59941a59512f0f6ea953b2d_3e74a4a99eba452da8d53a864fed508b);
            eventFunctions.Add("Snow_210ffdc08d1346ca8cbc9c445035f27d",Snow_210ffdc08d1346ca8cbc9c445035f27d);
            dialogueChecks.Add("Snow_9e0dc5bba4b246358942cbcd160ea492_524c2653aadb411fad31e5d363c75362",Snow_9e0dc5bba4b246358942cbcd160ea492_524c2653aadb411fad31e5d363c75362);
            eventFunctions.Add("Snow_1ffcedf6ecc14451953169bf0e2c60fa",Snow_1ffcedf6ecc14451953169bf0e2c60fa);
            dialogueChecks.Add("Snow_1bd94098072e48a19c6bf4bcf44707b8_77a63394b7394deb86cfa21018b1b5ef",Snow_1bd94098072e48a19c6bf4bcf44707b8_77a63394b7394deb86cfa21018b1b5ef);
            eventFunctions.Add("Snow_6e954fb8f913466a92f5b48db5d44066",Snow_6e954fb8f913466a92f5b48db5d44066);
            dialogueChecks.Add("Snow_92f7e0b9c6a444c6893a940388192a89_79c8ce98431d4de3b96940c96ca5cd54",Snow_92f7e0b9c6a444c6893a940388192a89_79c8ce98431d4de3b96940c96ca5cd54);
            eventFunctions.Add("Snow_18b862dbc9114e1a82a07bc290f8ca13",Snow_18b862dbc9114e1a82a07bc290f8ca13);
            dialogueChecks.Add("Snow_48bcc6a9d043418f9cae26f92318ed87_5df2282353ff4aafb805b30250cd34a0",Snow_48bcc6a9d043418f9cae26f92318ed87_5df2282353ff4aafb805b30250cd34a0);
            eventFunctions.Add("Snow_e2c31073e3124134ba303b464f283303",Snow_e2c31073e3124134ba303b464f283303);
            dialogueChecks.Add("Snow_6247a90fe04243848b3e3c6e83cfe823_511d3c63aa80479b97ef053f3487eacd",Snow_6247a90fe04243848b3e3c6e83cfe823_511d3c63aa80479b97ef053f3487eacd);
            dialogueChecks.Add("Snow_d2cf3f0a3a27461ca4d6b20f42464d7e_ef01b824564a47f08f1ccde405f28716",Snow_d2cf3f0a3a27461ca4d6b20f42464d7e_ef01b824564a47f08f1ccde405f28716);
            eventFunctions.Add("Snow_fb0b319889c74659bca159099803368f",Snow_fb0b319889c74659bca159099803368f);
            dialogueChecks.Add("Snow_247ccdb89a1d4b6da40f34c651502f42_5c4784b0a8234c4695866c0c866e586a",Snow_247ccdb89a1d4b6da40f34c651502f42_5c4784b0a8234c4695866c0c866e586a);
            dialogueChecks.Add("Snow_45b6d90b6230411fae90b1c80cce8ba4_9bf0bd43c0a14de0a1e22559aded8197",Snow_45b6d90b6230411fae90b1c80cce8ba4_9bf0bd43c0a14de0a1e22559aded8197);
            dialogueChecks.Add("Snow_179ebb5ae7c44b10ab690676bead30bb_8e7ac0cc135e46d4b4314d8eeb58d132",Snow_179ebb5ae7c44b10ab690676bead30bb_8e7ac0cc135e46d4b4314d8eeb58d132);
            eventFunctions.Add("Snow_36476e74f370481c919b0f99560febcb",Snow_36476e74f370481c919b0f99560febcb);
            dialogueChecks.Add("Snow_e873c7891de74c80b0684acd47c50106_c527d1d967c1492cb065ee16224b4b96",Snow_e873c7891de74c80b0684acd47c50106_c527d1d967c1492cb065ee16224b4b96);
            eventFunctions.Add("Snow_eb4e30eea88444daa1a71d87f3dcc22e",Snow_eb4e30eea88444daa1a71d87f3dcc22e);

        }

        // Dialogue Checks //
        // From Node: c7cd57fb-3b4a-49b1-bdb6-5dfb02db8f43 //
        // Choice: “Who was hopscotching here?” - bb30c90c-7a1e-4b06-afeb-282f6b76dcb6 //
        public bool Snow_c7cd57fb3b4a49b1bdb65dfb02db8f43_bb30c90c7a1e4b06afeb282f6b76dcb6()
        {
            return (true);
        }
        // From Node: 1cddfc8a-a7af-4f50-9d9a-01176c740275 //
        // Choice: “What a long hopscotch!” - 6b27e12a-f32d-4a22-bd92-e809a99b28ec //
        public bool Snow_1cddfc8aa7af4f509d9a01176c740275_6b27e12af32d4a22bd92e809a99b28ec()
        {
            return (true);
        }
        // From Node: 7343df01-2e67-49a5-a5e8-be25bf2f2352 //
        // Choice: “Who on earth drew a hopscotch this long?” - af5e39f2-d394-49cc-bc4b-cefe7403e025 //
        public bool Snow_7343df012e6749a5a5e8be25bf2f2352_af5e39f2d39449ccbc4bcefe7403e025()
        {
            return (true);
        }
        // From Node: c9397c59-a599-41a5-9512-f0f6ea953b2d //
        // Choice: “It may turn into a blizzard. Maybe I should go home now.” - 3e74a4a9-9eba-452d-a8d5-3a864fed508b //
        public bool Snow_c9397c59a59941a59512f0f6ea953b2d_3e74a4a99eba452da8d53a864fed508b()
        {
            return (true);
        }
        // From Node: 9e0dc5bb-a4b2-4635-8942-cbcd160ea492 //
        // Choice: “Oh, I had no idea. Where are you goin? Where does this all lead to?” - 524c2653-aadb-411f-ad31-e5d363c75362 //
        public bool Snow_9e0dc5bba4b246358942cbcd160ea492_524c2653aadb411fad31e5d363c75362()
        {
            return (true);
        }
        // From Node: 1bd94098-072e-48a1-9c6b-f4bcf44707b8 //
        // Choice: "What?" - 77a63394-b739-4deb-86cf-a21018b1b5ef //
        public bool Snow_1bd94098072e48a19c6bf4bcf44707b8_77a63394b7394deb86cfa21018b1b5ef()
        {
            return (true);
        }
        // From Node: 92f7e0b9-c6a4-44c6-893a-940388192a89 //
        // Choice: “I’m in trouble!” - 79c8ce98-431d-4de3-b969-40c96ca5cd54 //
        public bool Snow_92f7e0b9c6a444c6893a940388192a89_79c8ce98431d4de3b96940c96ca5cd54()
        {
            return (true);
        }
        // From Node: 48bcc6a9-d043-418f-9cae-26f92318ed87 //
        // Choice: “I’m going to do the same” - 5df22823-53ff-4aaf-b805-b30250cd34a0 //
        public bool Snow_48bcc6a9d043418f9cae26f92318ed87_5df2282353ff4aafb805b30250cd34a0()
        {
            return (true);
        }
        // From Node: 6247a90f-e042-4384-8b3e-3c6e83cfe823 //
        // Choice: “Grandmother, help!” - 511d3c63-aa80-479b-97ef-053f3487eacd //
        public bool Snow_6247a90fe04243848b3e3c6e83cfe823_511d3c63aa80479b97ef053f3487eacd()
        {
            return (true);
        }
        // From Node: d2cf3f0a-3a27-461c-a4d6-b20f42464d7e //
        // Choice: “Oh! Who dropped this for me?” - ef01b824-564a-47f0-8f1c-cde405f28716 //
        public bool Snow_d2cf3f0a3a27461ca4d6b20f42464d7e_ef01b824564a47f08f1ccde405f28716()
        {
            return (true);
        }
        // From Node: 247ccdb8-9a1d-4b6d-a40f-34c651502f42 //
        // Choice: “Why is the back of a mugwort leaf so white?” - 5c4784b0-a823-4c46-9586-6c0c866e586a //
        public bool Snow_247ccdb89a1d4b6da40f34c651502f42_5c4784b0a8234c4695866c0c866e586a()
        {
            return (true);
        }
        // From Node: 45b6d90b-6230-411f-ae90-b1c80cce8ba4 //
        // Choice: “That’s easy. It’s rabbit fur.\r Rabbits roll around I the field and shed their hair on mugwort leaves.”  - 9bf0bd43-c0a1-4de0-a1e2-2559aded8197 //
        public bool Snow_45b6d90b6230411fae90b1c80cce8ba4_9bf0bd43c0a14de0a1e22559aded8197()
        {
            return (true);
        }
        // From Node: 179ebb5a-e7c4-4b10-ab69-0676bead30bb //
        // Choice: “Mugwort, mugwort, mugwort in spring!”\r - 8e7ac0cc-135e-46d4-b431-4d8eeb58d132 //
        public bool Snow_179ebb5ae7c44b10ab690676bead30bb_8e7ac0cc135e46d4b4314d8eeb58d132()
        {
            return (true);
        }
        // From Node: e873c789-1de7-4c80-b068-4acd47c50106 //
        // Choice: “Ah, I’m safe” - c527d1d9-67c1-492c-b065-ee16224b4b96 //
        public bool Snow_e873c7891de74c80b0684acd47c50106_c527d1d967c1492cb065ee16224b4b96()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
        // Event From Node: df6ee159-d7e3-4f67-85ed-bc1a0e507d4a //
        public void Snow_df6ee159d7e34f6785edbc1a0e507d4a() {
dc = Utility.Toolbox.Instance.dialogue;
bg = Utility.Toolbox.Instance.bg;
        }
        // Event From Node: 2ff9b85e-8247-4ce1-9baa-76936205f3d2 //
        public void Snow_2ff9b85e82474ce19baa76936205f3d2() {
dc.EndConversation();
        }
        // Event From Node: f821bc2c-4317-403d-aef0-217b41e19801 //
        public void Snow_f821bc2c4317403daef0217b41e19801() {
dc.EndConversation();
        }
        // Event From Node: 210ffdc0-8d13-46ca-8cbc-9c445035f27d //
        public void Snow_210ffdc08d1346ca8cbc9c445035f27d() {
dc.EndConversation();
        }
        // Event From Node: 1ffcedf6-ecc1-4451-9531-69bf0e2c60fa //
        public void Snow_1ffcedf6ecc14451953169bf0e2c60fa() {
dc.EndConversation();
        }
        // Event From Node: 6e954fb8-f913-466a-92f5-b48db5d44066 //
        public void Snow_6e954fb8f913466a92f5b48db5d44066() {
dc.EndConversation();
        }
        // Event From Node: 18b862db-c911-4e1a-82a0-7bc290f8ca13 //
        public void Snow_18b862dbc9114e1a82a07bc290f8ca13() {
dc.EndConversation();
        }
        // Event From Node: e2c31073-e312-4134-ba30-3b464f283303 //
        public void Snow_e2c31073e3124134ba303b464f283303() {
dc.EndConversation();
        }
        // Event From Node: fb0b3198-89c7-4659-bca1-59099803368f //
        public void Snow_fb0b319889c74659bca159099803368f() {
dc.EndConversation();
        }
        // Event From Node: 36476e74-f370-481c-919b-0f99560febcb //
        public void Snow_36476e74f370481c919b0f99560febcb() {
dc.EndConversation();
        }
        // Event From Node: eb4e30ee-a884-44da-a1a7-1d87f3dcc22e //
        public void Snow_eb4e30eea88444daa1a71d87f3dcc22e() {
Hopscotch hs = GameObject.FindObjectOfType<Hopscotch>();
hs.gameObject.SetActive(false);
        }

    }
}
