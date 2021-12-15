using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Importing;

namespace Utility.Editor
{
    [InitializeOnLoad]
    public class DatabaseBuilder
    {
        static DatabaseBuilder()
        {
            UpdateSoundDatabase();
        }

        public static void UpdateSoundDatabase() 
        {
            Database db = Importer.Import("", null, "Assets/Resources/Audio", ".mp3", ".wav", ".ogg", ".aiff", ".aif");
            Importer.SaveDatabase(db, "Assets/Resources/Data/Database", "Audio");

            Database db2 = Importer.Import("", null, "Assets/Resources/Images", ".png", ".jpeg", ".jpg");
            Importer.SaveDatabase(db2, "Assets/Resources/Data/Database", "Images");
        }
    }
}