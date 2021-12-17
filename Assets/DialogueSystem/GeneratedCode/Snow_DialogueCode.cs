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
            dialogueChecks.Add("Snow_6247a90fe04243848b3e3c6e83cfe823_511d3c63aa80479b97ef053f3487eacd",Snow_6247a90fe04243848b3e3c6e83cfe823_511d3c63aa80479b97ef053f3487eacd);
            dialogueChecks.Add("Snow_d2cf3f0a3a27461ca4d6b20f42464d7e_ef01b824564a47f08f1ccde405f28716",Snow_d2cf3f0a3a27461ca4d6b20f42464d7e_ef01b824564a47f08f1ccde405f28716);
            eventFunctions.Add("Snow_fb0b319889c74659bca159099803368f",Snow_fb0b319889c74659bca159099803368f);
            dialogueChecks.Add("Snow_247ccdb89a1d4b6da40f34c651502f42_5c4784b0a8234c4695866c0c866e586a",Snow_247ccdb89a1d4b6da40f34c651502f42_5c4784b0a8234c4695866c0c866e586a);
            dialogueChecks.Add("Snow_45b6d90b6230411fae90b1c80cce8ba4_9bf0bd43c0a14de0a1e22559aded8197",Snow_45b6d90b6230411fae90b1c80cce8ba4_9bf0bd43c0a14de0a1e22559aded8197);
            dialogueChecks.Add("Snow_179ebb5ae7c44b10ab690676bead30bb_8e7ac0cc135e46d4b4314d8eeb58d132",Snow_179ebb5ae7c44b10ab690676bead30bb_8e7ac0cc135e46d4b4314d8eeb58d132);
            dialogueChecks.Add("Snow_e873c7891de74c80b0684acd47c50106_c527d1d967c1492cb065ee16224b4b96",Snow_e873c7891de74c80b0684acd47c50106_c527d1d967c1492cb065ee16224b4b96);
            eventFunctions.Add("Snow_eb4e30eea88444daa1a71d87f3dcc22e",Snow_eb4e30eea88444daa1a71d87f3dcc22e);
            eventFunctions.Add("Snow_df6ee159d7e34f6785edbc1a0e507d4a",Snow_df6ee159d7e34f6785edbc1a0e507d4a);
            eventFunctions.Add("Snow_ada0f4b615a24cb488da67b972a96f48",Snow_ada0f4b615a24cb488da67b972a96f48);
            dialogueChecks.Add("Snow_1cddfc8aa7af4f509d9a01176c740275_6b27e12af32d4a22bd92e809a99b28ec",Snow_1cddfc8aa7af4f509d9a01176c740275_6b27e12af32d4a22bd92e809a99b28ec);
            eventFunctions.Add("Snow_36cb81db2ab1431c804d9682b0fb8254",Snow_36cb81db2ab1431c804d9682b0fb8254);
            eventFunctions.Add("Snow_2831c63f2467404c87bf9ebcd2a1b432",Snow_2831c63f2467404c87bf9ebcd2a1b432);
            eventFunctions.Add("Snow_2510f94e35104650a6b20cb095b229e9",Snow_2510f94e35104650a6b20cb095b229e9);
            eventFunctions.Add("Snow_01043da602ba4f0a9b267b8bc638f850",Snow_01043da602ba4f0a9b267b8bc638f850);
            eventFunctions.Add("Snow_17631eba3ef9424db6aa49bcf354e10a",Snow_17631eba3ef9424db6aa49bcf354e10a);
            eventFunctions.Add("Snow_2940f037a6fa46a799e5a45299f3283e",Snow_2940f037a6fa46a799e5a45299f3283e);
            eventFunctions.Add("Snow_de08a1d505814710946c2dd28ce2541a",Snow_de08a1d505814710946c2dd28ce2541a);
            eventFunctions.Add("Snow_0b60f546a6024f6ebbd7dc5758ea40e4",Snow_0b60f546a6024f6ebbd7dc5758ea40e4);
            eventFunctions.Add("Snow_606f699fa965405ca25475a818a18b2f",Snow_606f699fa965405ca25475a818a18b2f);
            eventFunctions.Add("Snow_5726d19c62fc46738de0b644b8330194",Snow_5726d19c62fc46738de0b644b8330194);
            eventFunctions.Add("Snow_a6ebb57155a94896bda1001cad02d471",Snow_a6ebb57155a94896bda1001cad02d471);
            eventFunctions.Add("Snow_a64b69c7312744b5950bcc9f95f3077b",Snow_a64b69c7312744b5950bcc9f95f3077b);
            eventFunctions.Add("Snow_e2c31073e3124134ba303b464f283303",Snow_e2c31073e3124134ba303b464f283303);
            eventFunctions.Add("Snow_36476e74f370481c919b0f99560febcb",Snow_36476e74f370481c919b0f99560febcb);
            eventFunctions.Add("Snow_39f8083481024fc3a5832a8743755575",Snow_39f8083481024fc3a5832a8743755575);
            eventFunctions.Add("Snow_69b63f243aac44d7be056c580819ece5",Snow_69b63f243aac44d7be056c580819ece5);
            eventFunctions.Add("Snow_8ea018ba5e6d4ee094b82c87212df107",Snow_8ea018ba5e6d4ee094b82c87212df107);
            eventFunctions.Add("Snow_2225aa80486e4d4084925729e925c4be",Snow_2225aa80486e4d4084925729e925c4be);
            eventFunctions.Add("Snow_01a8f4d5d06b46a89f16f10ce7f17512",Snow_01a8f4d5d06b46a89f16f10ce7f17512);
            eventFunctions.Add("Snow_a96417919b114047b05ea52e179c42b6",Snow_a96417919b114047b05ea52e179c42b6);
            eventFunctions.Add("Snow_5e44bd88edfa4a4a8d73a01e0fc67c28",Snow_5e44bd88edfa4a4a8d73a01e0fc67c28);
            dialogueChecks.Add("Snow_23d3ab7df7ea489fa9dac0ccfd277983_2583665232844ec5b48e41237d2e7ee4",Snow_23d3ab7df7ea489fa9dac0ccfd277983_2583665232844ec5b48e41237d2e7ee4);

        }

        // Dialogue Checks //
        // From Node: c7cd57fb-3b4a-49b1-bdb6-5dfb02db8f43 //
        // Choice: “Who was hopscotching here?” - bb30c90c-7a1e-4b06-afeb-282f6b76dcb6 //
        public bool Snow_c7cd57fb3b4a49b1bdb65dfb02db8f43_bb30c90c7a1e4b06afeb282f6b76dcb6()
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
        // Choice: “That’s easy. It’s rabbit fur.\r”  - 9bf0bd43-c0a1-4de0-a1e2-2559aded8197 //
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
        // From Node: 1cddfc8a-a7af-4f50-9d9a-01176c740275 //
        // Choice: “What a long hopscotch!” - 6b27e12a-f32d-4a22-bd92-e809a99b28ec //
        public bool Snow_1cddfc8aa7af4f509d9a01176c740275_6b27e12af32d4a22bd92e809a99b28ec()
        {
            return (true);
        }
        // From Node: 23d3ab7d-f7ea-489f-a9da-c0ccfd277983 //
        // Choice: “Rabbits roll around I the field and shed their hair on mugwort leaves.”  - 25836652-3284-4ec5-b48e-41237d2e7ee4 //
        public bool Snow_23d3ab7df7ea489fa9dac0ccfd277983_2583665232844ec5b48e41237d2e7ee4()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
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
        // Event From Node: fb0b3198-89c7-4659-bca1-59099803368f //
        public void Snow_fb0b319889c74659bca159099803368f() {
dc.EndConversation();
        }
        // Event From Node: eb4e30ee-a884-44da-a1a7-1d87f3dcc22e //
        public void Snow_eb4e30eea88444daa1a71d87f3dcc22e() {
bg.Next();
Hopscotch hs = GameObject.FindObjectOfType<Hopscotch>();
hs.gameObject.SetActive(false);
        }
        // Event From Node: df6ee159-d7e3-4f67-85ed-bc1a0e507d4a //
        public void Snow_df6ee159d7e34f6785edbc1a0e507d4a() {
dc = Utility.Toolbox.Instance.dialogue;
bg = Utility.Toolbox.Instance.bg;
bg.Next();
        }
        // Event From Node: ada0f4b6-15a2-4cb4-88da-67b972a96f48 //
        public void Snow_ada0f4b615a24cb488da67b972a96f48() {
bg.Next();
        }
        // Event From Node: 36cb81db-2ab1-431c-804d-9682b0fb8254 //
        public void Snow_36cb81db2ab1431c804d9682b0fb8254() {
bg.Next();
        }
        // Event From Node: 2831c63f-2467-404c-87bf-9ebcd2a1b432 //
        public void Snow_2831c63f2467404c87bf9ebcd2a1b432() {
bg.Next();
        }
        // Event From Node: 2510f94e-3510-4650-a6b2-0cb095b229e9 //
        public void Snow_2510f94e35104650a6b20cb095b229e9() {
bg.Next();
        }
        // Event From Node: 01043da6-02ba-4f0a-9b26-7b8bc638f850 //
        public void Snow_01043da602ba4f0a9b267b8bc638f850() {
bg.Next();
        }
        // Event From Node: 17631eba-3ef9-424d-b6aa-49bcf354e10a //
        public void Snow_17631eba3ef9424db6aa49bcf354e10a() {
bg.Next();
        }
        // Event From Node: 2940f037-a6fa-46a7-99e5-a45299f3283e //
        public void Snow_2940f037a6fa46a799e5a45299f3283e() {
bg.Next();
        }
        // Event From Node: de08a1d5-0581-4710-946c-2dd28ce2541a //
        public void Snow_de08a1d505814710946c2dd28ce2541a() {
bg.Next();
        }
        // Event From Node: 0b60f546-a602-4f6e-bbd7-dc5758ea40e4 //
        public void Snow_0b60f546a6024f6ebbd7dc5758ea40e4() {
bg.Next();
        }
        // Event From Node: 606f699f-a965-405c-a254-75a818a18b2f //
        public void Snow_606f699fa965405ca25475a818a18b2f() {
bg.Next();
        }
        // Event From Node: 5726d19c-62fc-4673-8de0-b644b8330194 //
        public void Snow_5726d19c62fc46738de0b644b8330194() {
bg.Next();
        }
        // Event From Node: a6ebb571-55a9-4896-bda1-001cad02d471 //
        public void Snow_a6ebb57155a94896bda1001cad02d471() {
bg.Next();
        }
        // Event From Node: a64b69c7-3127-44b5-950b-cc9f95f3077b //
        public void Snow_a64b69c7312744b5950bcc9f95f3077b() {
bg.Next();
        }
        // Event From Node: e2c31073-e312-4134-ba30-3b464f283303 //
        public void Snow_e2c31073e3124134ba303b464f283303() {
dc.EndConversation();
        }
        // Event From Node: 36476e74-f370-481c-919b-0f99560febcb //
        public void Snow_36476e74f370481c919b0f99560febcb() {
dc.EndConversation();
        }
        // Event From Node: 39f80834-8102-4fc3-a583-2a8743755575 //
        public void Snow_39f8083481024fc3a5832a8743755575() {
bg.Next();
        }
        // Event From Node: 69b63f24-3aac-44d7-be05-6c580819ece5 //
        public void Snow_69b63f243aac44d7be056c580819ece5() {
bg.Next();
        }
        // Event From Node: 8ea018ba-5e6d-4ee0-94b8-2c87212df107 //
        public void Snow_8ea018ba5e6d4ee094b82c87212df107() {
bg.Next();
        }
        // Event From Node: 2225aa80-486e-4d40-8492-5729e925c4be //
        public void Snow_2225aa80486e4d4084925729e925c4be() {
bg.Next();
        }
        // Event From Node: 01a8f4d5-d06b-46a8-9f16-f10ce7f17512 //
        public void Snow_01a8f4d5d06b46a89f16f10ce7f17512() {
bg.Next();
        }
        // Event From Node: a9641791-9b11-4047-b05e-a52e179c42b6 //
        public void Snow_a96417919b114047b05ea52e179c42b6() {
bg.Next();
        }
        // Event From Node: 5e44bd88-edfa-4a4a-8d73-a01e0fc67c28 //
        public void Snow_5e44bd88edfa4a4a8d73a01e0fc67c28() {
bg.Next();
        }

    }
}
