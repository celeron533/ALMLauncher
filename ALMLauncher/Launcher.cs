﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ALMLauncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            try
            {
                var deployments = GetDeployments();
                listBoxDep.DisplayMember = "URL";
                listBoxDep.DataSource = deployments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        List<DeploymentInfo> GetDeployments()
        {
            List<DeploymentInfo> deploymentInfos = new List<DeploymentInfo>();
            var deployments = Directory.GetDirectories(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"HP\ALM-Client\"));

            foreach (var dep in deployments)
            {
                string serverUrl = GetServerUrl(dep);
                DeploymentInfo deploymentInfo = new DeploymentInfo
                {
                    Name = dep.Split('\\').Last(),
                    Path = dep,
                    URL = serverUrl
                };
                deploymentInfos.Add(deploymentInfo);
            }

            return deploymentInfos;
        }

        string GetServerUrl(string deploymentPath)
        {
            const int MAX = 256;
            string iniFilePath = Path.Combine(deploymentPath, "DSummary.ini");
            StringBuilder serverUrl = new StringBuilder(MAX);
            GetPrivateProfileString("General", "ServerURL", "", serverUrl, MAX, iniFilePath);
            return serverUrl.ToString();
        }

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                string key, string def, StringBuilder retVal,
           int size, string filePath);


        class DeploymentInfo
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public string URL { get; set; }
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            Launch(listBoxDep.SelectedItem as DeploymentInfo);
        }

        void Launch(DeploymentInfo selected, bool debug = false, bool enableAccessibility = false, bool isFrameworkOnlyMode = false)
        {
            if (selected == null) return;

            try
            {
                string exePath = Path.Combine(selected.Path, "ALM-Client.exe");

                string arguments = $"TDtesttypes=\"{selected.Path}\" ConfigurationFile=\"{exePath}\" PrivatePath=\"3rdParty\" URL=\"{selected.URL}\"";

                if (debug)
                {
                    arguments += " DebugClient=true DebugStartup=true";
                }

                if (enableAccessibility)
                {
                    arguments += " EnableAccessibility=Y";
                }

                if (isFrameworkOnlyMode)
                {
                    arguments += " FrameworkOnlyMode=Y";
                }

                Process.Start(exePath, arguments);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBoxDep_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxDep.IndexFromPoint(e.X, e.Y);
            if (index != ListBox.NoMatches)
            {
                listBoxDep.SelectedIndex = index;
                Launch(listBoxDep.SelectedItem as DeploymentInfo);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/celeron533/ALMLauncher");
        }

        private void openContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFolder(listBoxDep.SelectedItem as DeploymentInfo);
        }

        private void OpenFolder(DeploymentInfo deploymentInfo)
        {
            if (deploymentInfo == null) return;
            Process.Start("explorer.exe", deploymentInfo.Path);
        }

        private void launchInDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launch(listBoxDep.SelectedItem as DeploymentInfo, true);
        }
    }
}
