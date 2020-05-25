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

        public string FIDCategory
        {
            get => _fidC;
            set
            {
                _fidC = value;
                OnPropertyChanged("FIDCategory");
            }
        }

        public string FCPLighthous
        {
            get => _fcpL;
            set
            {
                _fcpL = value;
                OnPropertyChanged("FCPLighthous");
            }
        }

        public string SiLighthous
        {
            get => _siL;
            set
            {
                _siL = value;
                OnPropertyChanged("SiLighthous");
            }
        }

        public string TtiLighthous
        {
            get => _ttiL;
            set
            {
                _ttiL = value;
                OnPropertyChanged("TtiLighthous");
            }
        }

        public string FmpLighthous
        {
            get => _fmpL;
            set   
            {
                _fmpL = value;
                OnPropertyChanged("FmpLighthous");
            }
        }

        public string FciLighthous
        {
            get => _fciL; 
            set 
            {
                _fciL = value; 
                OnPropertyChanged("FciLighthous"); 
            }
        }

        public string EilLighthous
        {
            get => _eilL; set 
            { 
                _eilL = value; 
                OnPropertyChanged("EilLighthous"); 
            }
        }
    }
}
