using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Zsizsinstall : Form
    {


        private void Zsizsinstall_Load(object sender, EventArgs e)
        {

        }

        public int CountOfPrograms = 0;
        string location;
        string txtline = "";

        public Zsizsinstall()
        {

            //StreamReader route = File.OpenText("installroutes.txt");
            //while ((txtline = route.ReadLine()) != null)
            //{
            //    string[] array = txtline.Split(';');
            //    Installoptions.Items.Add(new Tolt(array[0], array[1], array[2]));
            //    CountOfPrograms++;
            //}
            //route.Close();
            /*nagyon bele írtam.*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < CountOfPrograms; i++)
                {
                    location = Convert.ToString(txtline[CountOfPrograms * 3]);
                    Fugg.InstallCall(location);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
    public class Fugg
    {
        public static void InstallCall(string route)
        {
            Process install = new Process();
            install.StartInfo.FileName = @route;
            install.Start();
            install.WaitForExit();
        }
        public string RouteSearch()
        {

            return ("");
        }

    }

    public class Tolt
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }

        public Tolt(string name, string version, string path)
        {
            Name = name;
            Version = version;
            Path = path;
        }

    }
}