using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Importing;
using UnityEngine.Networking;
using UnityEngine.Events;
using System;

namespace Sound
{
    public class BackgroundDatabase
    {
        private Database baked_db;
        public BackgroundDatabase()
        {
            baked_db = Importer.LoadDatabase("Data/Database", "Background");
        }

        /// <summary>
        /// Returns a list of audio clips from the folder <paramref name="location"/> provided. They should be in "Resources/Audio"
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public List<Texture2D> GrabImage(string location)
        {
            List<Texture2D> clips = new List<Texture2D>();
            try
            {
                location = SanitizePath(location);
                Folder dir = baked_db.Folders[location];

                foreach (File file in dir.Files)
                {
                    string clipPath = System.IO.Path.ChangeExtension($"Background\\{file.FileLocation}", string.Empty);
                    clipPath = clipPath.Substring(0, clipPath.Length - 1);
                    Texture2D c = Resources.Load<Texture2D>(clipPath);
                    if (c != null)
                        clips.Add(c);
                }

                return clips;
            }
            catch
            {
                return clips;
            }
        }

        private static string SanitizePath(string s)
        {
            return s.Replace('/', '\\');
        }
    }
}
