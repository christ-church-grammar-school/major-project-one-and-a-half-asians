﻿using HayStack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Hey_Stack_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ChatAppBtnClick(object sender, RoutedEventArgs e)
        {
            ShowMyChatApp();
            //Process p = new Process();
            //need to figure this part out
            //p.StartInfo = new ProcessStartInfo("C:\\User Program Files\\major-project-one-and-a-half-asians\\ChatterClient\\bin\\Debug\\ChatterClient.exe");
            //p.Start();

        }

        private void ShowMyChatApp()
        {
            Chatapp MyPage = new Chatapp();
            var ChatappContents = Content;
            Content = MyPage;
            MyPage.ladder += (object sender, EventArgs e) =>
            {
                Content = ChatappContents;
            };
        }


        private void ToDoBtnClick(object sender, RoutedEventArgs e)
        {
            ShowMyToDo();
        }
        private void ShowMyToDo()
        {
            ToDoReal MyPage = new ToDoReal();
            var TodoContents = Content;
            Content = MyPage;
            MyPage.ladder += (object sender, EventArgs e) =>
            {
                Content = TodoContents;
            };
        }


        private void TimetableBtnClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nexus.ccgs.wa.edu.au/timetable");
        }

        private void ContactsBtnClick(object sender, RoutedEventArgs e)
        {
            ShowMyContacts();
        }


        private void ShowMyContacts()
        {
            if (!Application.Current.Windows.OfType<ContactsReal>().Any())
            {
                ContactsReal ContactPage = new ContactsReal();
                ContactPage.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Contacts is already open.");
            }
        }

        private void OpenGoogle(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void InfoBtnClick(object sender, RoutedEventArgs e)
        {
            ShowMyInfo();
        }
        private void ShowMyInfo()
        {
            Info MyPage = new Info();
            var InfoContents = Content;
            Content = MyPage;
            MyPage.ladder += (object sender, EventArgs e) =>
            {
                Content = InfoContents;
            };
        }

        private void OpenMail(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("mailto://"));
        }

        private void OpenNexus(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nexus.ccgs.wa.edu.au/");
        }

        private void SettingBtnClick(object sender, RoutedEventArgs e)
        {
            ShowMySettings();
        }
        private void ShowMySettings()
        {
            Settings MyPage = new Settings();
            var SettingsContent = Content;
            Content = MyPage;
            MyPage.ladder += (object sender, EventArgs e) =>
            {
                Content = SettingsContent;
            };
        }

    }
}
