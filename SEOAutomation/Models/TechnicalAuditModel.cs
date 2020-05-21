using System;
using System.Collections.Generic;
using System.Text;

namespace SEOAutomation.Models
{
    public class TechnicalAuditModel : BindableBase
    {
        //Chrome user Experience Report Result
        private string _fcpC;
        private string _fidC;
        //Lighthous Result
        private string _fcpL;
        private string _siL;
        private string _ttiL;
        private string _fmpL;
        private string _fciL;
        private string _eilL;

        public string FCPCategory 
        { 
            get => _fcpC; 
            set 
            {
                _fcpC = value;
                OnPropertyChanged("FCPCategory");
            } 
        }
    }
}
