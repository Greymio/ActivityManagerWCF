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
using WPFActivityManager.Views;

namespace WPFActivityManager.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {

        private DelegateCommand _ActivityCmd;
        private DelegateCommand _ScheduleCmd;
        private DelegateCommand _PeopleCmd;
        private DelegateCommand _SearchCmd;

        public DelegateCommand ActivityCmd
        {
            get { return _ActivityCmd=_ActivityCmd?? new DelegateCommand(CmdActivity); }
        }
        public DelegateCommand ScheduleCmd
        {
            get { return _ScheduleCmd = _ScheduleCmd ?? new DelegateCommand(CmdSchedule); }
        }    
        public DelegateCommand PeopleCmd
        {
            get { return _PeopleCmd = _PeopleCmd ?? new DelegateCommand(CmdPeople); }
        }
        public DelegateCommand SearchCmd
        {
            get { return _SearchCmd = _SearchCmd ?? new DelegateCommand(CmdSearch); }
        }


        private void CmdPeople()
        {
            
        }

        private void CmdSchedule()
        {
            
        }
       
        private void CmdSearch()
        {
            
        }

        private void CmdActivity()
        {
            ActivityView fen = new ActivityView();
            fen.ShowDialog();
        }

    }
}
