using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WPFActivityManager.ActivityService;
using WPFActivityManager.Model;
using WPFActivityManager.Tools;

namespace WPFActivityManager.ViewModel
{
    public class ActivityViewModel:ViewModelBase
    {
        ActivityServiceClient _Cli;

        ObservableCollection<ActivityClient> _lActivity;
        ActivityClient _selectedItem;

        DelegateCommand _CmdSave;

        public DelegateCommand CmdSave
        {
            get { return _CmdSave=_CmdSave?? new DelegateCommand(FnSave); }
        }

        


        public ActivityClient SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; RaisePropertyChanged("SelectedItem"); }
        }

        public ObservableCollection<ActivityClient> LActivity
        {
            get { return _lActivity=_lActivity?? new ObservableCollection<ActivityClient>(); }
            set { _lActivity = value; }
        }


        public ActivityViewModel()
        {
            _Cli = new ActivityService.ActivityServiceClient();

            try
            {
                List<Activity> la = _Cli.getActivities(WPFActivityManager.Properties.Settings.Default.License);
                List<ActivityClient> lac = la.Select(l => ActivityClient.LoadFromService(l)).ToList();

                foreach (ActivityClient item in lac)
                {
                    LActivity.Add(item);
                }

            }
            catch (FaultException<ActivityFaultContract> Fe)
            {
                WpfUIWindowDialogService uiser = new WpfUIWindowDialogService();
                uiser.ShowDialog("Information", string.Format("{0} \r\n {1}", Fe.Reason, Fe.Detail.ErrorMessage));
            }
        }

        private void FnSave()
        {
            //monservice.SaveActivity(SelectedItem en tant que activity pour le service);

            Activity aToTrans =  new Activity();
             aToTrans.Libelle = SelectedItem.Libelle;
                aToTrans.Description = SelectedItem.Description;
                aToTrans.Adress = SelectedItem.Adress;
                aToTrans.Num = SelectedItem.Num;
                aToTrans.Zip = SelectedItem.Zip;
                aToTrans.City = SelectedItem.City;
                aToTrans.IdSubActivity = SelectedItem.IdSubActivity;
            aToTrans.IdActivity = SelectedItem.IdActivity;

           
            try
            {
                _Cli.SaveActivity(aToTrans); 
            }
             catch (FaultException<ActivityFaultContract> Fe)
            {
                WpfUIWindowDialogService uiser = new WpfUIWindowDialogService();
                uiser.ShowDialog("Information", string.Format("{0} \r\n {1}", Fe.Reason, Fe.Detail.ErrorMessage));
            }
           
            
        }
    }
}
