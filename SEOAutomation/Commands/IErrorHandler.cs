using System;
using System.Collections.Generic;
using System.Text;

namespace SEOAutomation.Commands
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
