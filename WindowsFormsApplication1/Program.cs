using System;
using System.Windows.Forms;
using System.Xml;
using GuessTheMelody.Core;

namespace GuessTheMelody
{
    static class Program
    {
        public static string userName = "";

        public static void loadUsers()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("score.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                string _name = "";
                string _level = "";
                int _score = 0;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        _name = childnode.InnerText;
                    }
                    if (childnode.Name == "level")
                    {
                        _level = childnode.InnerText;
                    }
                    if (childnode.Name == "score")
                    {
                        _score = Convert.ToInt32(childnode.InnerText);
                    }
                }
                Users.Instance.Add(new User(_name, _level, _score));
            }
        }

        private static void loadSongs()
        {
            Songs s = Songs.Instanse;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("songs.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                Song song = new Song();

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        song.name = childnode.InnerText;
                    }
                    if (childnode.Name == "file")
                    {
                        song.filePath = "songs/" + childnode.InnerText;
                    }
                    if (childnode.Name == "variants")
                    {
                        int i = 0;
                        String[] answers = new String[4];
                        foreach (XmlNode item in childnode.ChildNodes)
                        {
                            if (item.Name == "answer")
                                answers[i++] = item.InnerText;
                        }
                        song.answer = answers;
                    }
                }
                song.Init();

                s.Add(song);
            }
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            loadSongs();
            loadUsers();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
