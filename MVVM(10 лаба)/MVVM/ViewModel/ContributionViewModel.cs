using MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MVVM.ViewModel
{
 public   class ContributionViewModel : DependencyObject
    {


        public string Filter
        {
            get { return (string)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }

        public static readonly DependencyProperty FilterProperty =
            DependencyProperty.Register("FilterProperty", typeof(string), typeof(ContributionViewModel), new PropertyMetadata("",FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var contribution = d as ContributionViewModel;
            if (contribution != null)
            {
                contribution.Items.Filter = null;
                contribution.Items.Filter = contribution.FilerContribution;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty,value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("ItemsProperty", typeof(ICollectionView), typeof(ContributionViewModel), new PropertyMetadata(null));

      //  public event PropertyChangedEventHandler PropertyChanged;

        public ContributionViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Contribution.GetContribution());
            Items.Filter = FilerContribution;
        }

        private bool FilerContribution(object obj)
        {
            bool result = true;
            Contribution contribution = obj as Contribution;
            if (!contribution.Investor.Name.Contains(Filter) && !contribution.Type.Contains(Filter) && !string.IsNullOrWhiteSpace(Filter))
            {

                result = false;
            }
            return result;
        }
    }
}
