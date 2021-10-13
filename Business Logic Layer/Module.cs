using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    public class Module: IModule
    {
        int moduleCode;
        string moduleName;
        string description;

        List<string> onlineResources = new List<string>();
        List<Module> Modules = new List<Module>();

        public Module(int moduleCode, string moduleName, string description, List<string> resources)//*
        {
            this.moduleCode = moduleCode;
            this.moduleName = moduleName;
            this.description = description;
            this.onlineResources = resources;//*
        }

        public int ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string Description { get => description; set => description = value; }

        //Module validation

        //References DH to insert module (C)
        public string validateModuleInfo(Module m)
        {
            
            return "New Module has been added.";
        }

        //Fetches all Modules from DH (R)
        public List<Module> getModuless()
        {
            return Modules;
        }

        //confirms update (U)
        public string moduleInfoChanged(Module m)
        {
            return "Module with Code: " + ", has been updated.";
        }
        //Deletes Module (D)
        public string moduleDeleted(int sNum)
        {
            return "Module Deleted";
        }

        //returns the new filtered source for DGV 
        public List<Module> searchModule(string mCode)
        {
            return new List<Module>();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}