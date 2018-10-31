using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EnumsAndStructs
{
    public enum MenuFirstTask : int
    {
        CompanyInfo = 1,
        MoreThanClerk,
        LaterThanBoss,
        Exit
    }

    public enum MenuSecondTask : int
    {
        UniversityInfo = 1,
        Obshaga,
        Exit
    }

    public enum MainMenu : int
    {
        FirstTask = 1,
        Secondtask
    }
}
