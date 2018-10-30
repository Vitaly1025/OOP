using System;
using System.Collections.Generic;
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

namespace Laba12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    #region Abstract Factory
    public interface IBlood
    {
        string Blood { get; }
    }   

    public interface IArms
    {
        string Type { get; }
    }

    public interface IFactory
    {
        IBlood CreateBlood();
        IArms CreateArms(); 
    }

    public class BelarusBlood : IBlood
    {
        public string Blood => "Белорусская кровь";
    }

    public class SpartaBlood : IBlood
    {
        public string Blood => "Спартанская кровь";
    }

    public class BelarusArms : IArms
    {
        public string Type => "Горячая кортошка";
    }

    public class SpartaArms : IArms
    {
        public string Type => "Мечь спартанца";
    }

    public class BelarusWarrior : IFactory
    {
        public IArms CreateArms()
        {
            return new BelarusArms();
        }

        public IBlood CreateBlood()
        {
            return new BelarusBlood();
        }
    }

    public class SpartaWarrior : IFactory
    {
        public IArms CreateArms()
        {
            return new SpartaArms();
        }

        public IBlood CreateBlood()
        {
            return new SpartaBlood();
        }
    }
    #endregion

    #region Singltone
    public sealed class Leader
    {
        private static Leader _leader;
        public Leader()
        {

        }
        public static Leader GetLeader()
        {
            return _leader ?? (_leader = new Leader());
        }
    }

    #endregion

    #region Builder
    public class War
    {
        public SpartaWarrior  SpartaWarrior { get; set; }
        public BelarusWarrior BelarusWarrior { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            IFactory factory = new SpartaWarrior();
            var arms = factory.CreateArms();
            if (arms != null)
                sb.Append("Спартанские войска Оружие: " + arms.Type + " \n");
           
            return sb.ToString();
        }

    }
    #endregion


    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void SPARTA(object sender, RoutedEventArgs e)
        {
            IFactory factory = new SpartaWarrior();
            var blood = factory.CreateBlood();
            var arms = factory.CreateArms();
            MessageBox.Show("Вы создали объект спартанцас параметрами:\nТип крови: " + blood.Blood + "\nТип оружия: " + arms.Type);
        }

        private void BELARUS(object sender, RoutedEventArgs e)
        {
            IFactory factory = new BelarusWarrior();
            var blood = factory.CreateBlood();
            var arms = factory.CreateArms();
            MessageBox.Show("Вы создали объект Беларуса с параметрами:\nТип крови: " + blood.Blood + "\nТип оружия: " + arms.Type);
        }

        private void WAR(object sender, RoutedEventArgs e)
        {
            War war = new War();
            MessageBox.Show(war.ToString());
        }
    }
}