﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using Microsoft.Win32;
using Time_Table_Arranging_Program.Class;
using Time_Table_Arranging_Program.Class.Helper;
using Time_Table_Arranging_Program.Windows_Control;

namespace Time_Table_Arranging_Program.Pages {
    /// <summary>
    /// Interaction logic for Page_SaveTimetableAsImage.xaml
    /// </summary>
    public partial class Page_SaveTimetableAsImage : Page {
        public Page_SaveTimetableAsImage(ITimetable input) {
            InitializeComponent();
            TimeTableGui.GenerateGUI(input);
        }

        private void SaveImageButton_OnClick(object sender , RoutedEventArgs e) {
            var saveDialog = new SaveFileDialog() { Filter = "Image file (*.png)|*.png" , FileName = "MyTimetable.png" };
            if (saveDialog.ShowDialog() == false) return;
            try {
                var bitmap = Helper.GetImage(this.TimeTableGui);
                //var bg = CustomBackgroundWorker<RenderTargetBitmap , string>.RunAndShowLoadingScreen(
                //    Helper.SaveAsPng ,
                //bitmap , saveDialog.FileName , "Saving file . . .");
                Helper.SaveAsPng(bitmap, saveDialog.FileName);
                Global.Snackbar.MessageQueue.Enqueue("File saved at " + saveDialog.FileName, "OPEN",
                    () => { Process.Start(saveDialog.FileName); });
            }

            catch (Exception ex) {
                Global.Snackbar.MessageQueue.Enqueue("Failed to save file.");
            }

        }
    }
}
