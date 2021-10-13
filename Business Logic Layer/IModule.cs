using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    public interface IModule
    {

        //References DH to insert module when cirteria is met (C)
        string validateModuleInfo(Module m);


        //Fetches all Modules from DH (R)
        List<Module> getModules();


        //confirms update and sends relevant message (U)
        string moduleInfoChanged(Module m);

        //Deletes Module and sends relevant message (D)
        string moduleDeleted(int sNum);


        //returns the new filtered source for DGV according to a search 
        List<Module> searchModule(int mCode);
        
    }
}
