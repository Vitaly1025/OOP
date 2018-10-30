using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Globalization;

namespace LABA45
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow :Window
    {
        public int Counter { get; set; }
        public MainWindow()
        {
          
            InitializeComponent();
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;
            menulang.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menulang.Items.Add(menuLang);
            }
            //List<string> styles = new List<string> { "light", "dark" };
            //styleBox.SelectionChanged += ThemeChange;
            //styleBox.ItemsSource = styles;
            //styleBox.SelectedItem = "dark";
            ////LOADING FONTS_FAMILIES 
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (System.Drawing.FontFamily font in fonts.Families)
            {
                Font_family.Items.Add(font.Name);
            }
            Font_family.SelectedIndex = 1;
            Font_id.Content = Size.Value;
            Binding binding = new Binding();
            binding.Source = Counter;
            State.SetBinding(TextBlock.TextProperty, binding); // установка привязки для элемента-приемника

        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

        }


        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menulang.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void Open_File_Click(object sender, RoutedEventArgs e)
        {
            //FlowDocument objdoc = new FlowDocument();
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Rich text documents (.rtf)|*.rtf"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                
                string filename = dlg.FileName;
                TextRange doc = new TextRange(TextArea.Document.ContentStart, TextArea.Document.ContentEnd);
                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
                {
                        doc.Load(fs, DataFormats.Rtf);
                   
                }
                //TextArea.Document = doc.;
            }

        }


        private void Save_File_Click(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(TextArea.Document.ContentStart, TextArea.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }

        private void TextArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBlock textBlock = new TextBlock();
            TextRange textarea = new TextRange(TextArea.Document.ContentStart, TextArea.Document.ContentEnd);
            TextPointer start_pointer, end_pointer; 
          
            try
            {
                start_pointer = TextArea.Document.ContentStart.GetNextContextPosition(LogicalDirection.Forward).GetPositionAtOffset(1);
                end_pointer = textarea.End;
                Counter = textarea.Text.Replace("\r\n", "").Length;
                State.Text = "Количество символов: " + textarea.Text.Replace("\r\n", "").Length.ToString();
            }
            catch(Exception ex) { }
        }

        private void Slider_ValueChanged(object sender, RoutedEventArgs e)
        {
           
            try
            {
              
                Font_id.Content = Size.Value;
                TextArea.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, Size.Value);
                // TextArea_SelectionChanged(sender, e);
            }
            catch (Exception ex)

            {

            }
           
        }

        private void TextArea_SelectionChanged(object sender, RoutedEventArgs e)
        {

            ///////////////Bold////////
            try
            {
                
                TextArea.Selection.ApplyPropertyValue(Run.FontFamilyProperty, Font_family.SelectedValue);

                if ((double)TextArea.Selection.GetPropertyValue(TextElement.FontSizeProperty) != Size.Value && TextArea.Selection.Start!= TextArea.Selection.End)
                {
                    Size.Value = (double)TextArea.Selection.GetPropertyValue(TextElement.FontSizeProperty);

                }

                else
                {
                     Slider_ValueChanged(sender, e);
                }

             //   Size.Value = (double)TextArea.Selection.GetPropertyValue(TextElement.FontSizeProperty);


             //   
                if ((FontWeight)TextArea.Selection.GetPropertyValue(Run.FontWeightProperty) == FontWeights.Bold)
                {
                    Bold.IsChecked = true;

                }
                else
                {
                    Bold.IsChecked = false;
                }
            }
            catch(Exception ex)
            {
             //   State.Text = ex.Message;
            }
            ////////////// Italic////////
            try
            {
                if ((System.Windows.FontStyle)TextArea.Selection.GetPropertyValue(Run.FontStyleProperty) == FontStyles.Italic)
                {
                    Italic.IsChecked = true;

                }
                else
                {
                    Italic.IsChecked = false;
                }
            }
            catch (Exception ex)
            {
                State.Text = ex.Message;
            }
            //////////UnderLine///////
            try
            {
                if ((TextDecorationCollection)TextArea.Selection.GetPropertyValue(Paragraph.TextDecorationsProperty) == TextDecorations.Underline)
                {
                    Underline.IsChecked = true;

                }
                else
                {
                    Underline.IsChecked = false;
                }
            }
            catch (Exception ex)
            {
                State.Text = ex.Message;
            }
        }

        private void Font_family_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
  
              TextArea.Selection.ApplyPropertyValue(Run.FontFamilyProperty, Font_family.SelectedValue);


        }

        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Bold.IsChecked)
            {
                State.Text = "enabled bold";
                TextArea.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Bold);
            }
            else
            {
                State.Text = "disenabled bold";
                TextArea.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);
            }

        }

        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Italic.IsChecked)
            {
                State.Text = "enabled italic";
                TextArea.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Italic);
            }
            else
            {
                State.Text = "disenabled italic";
                TextArea.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);
            }
        }

        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            
            if ((bool)Underline.IsChecked)
            {
                State.Text = "enabled underline";
                TextArea.Selection.ApplyPropertyValue(Paragraph.TextDecorationsProperty, TextDecorations.Underline);
            }
            else
            {
                State.Text = "disenabled underline";
                TextArea.Selection.ApplyPropertyValue(Paragraph.TextDecorationsProperty, null);
            }
        }

        private void cnf_click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            
            window.Show();
        }

        private void menulang_Click(object sender, RoutedEventArgs e)
        {

        }

      
        private void Undo_click(object sender, RoutedEventArgs e)
        {
            TextArea.Undo();
        }

        private void Redo_click(object sender, RoutedEventArgs e)
        {
            TextArea.Redo();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Drag_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                var file = files[0];
                TextRange doc = new TextRange(TextArea.Document.ContentStart, TextArea.Document.ContentEnd);
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    doc.Load(fs, DataFormats.Rtf);
                }

            }
        }

        private void HandleFile(string file)
        {
            throw new NotImplementedException();
        }

        private void Textarea_Drop(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }
    }
}

