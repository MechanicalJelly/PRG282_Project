using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRG282_Project;


namespace PRG282_Project
{
    public class Module: IModule
    {
        int moduleCode;
        string moduleName;
        string description;


       DataHandler handle = new DataHandler();
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
        public string validation(string mN, string des)
        {

            if (string.IsNullOrEmpty(mN))
            {
                return "Empty!!Enter a module name!!";
            }
            else if (string.IsNullOrEmpty(des))
            {
                return "Empty!!Enter a description!!";
            }
           
            else
            {
                return "Successful validation";
            }
        }
     
        //[C] Runs validation, if everything is correct, attempts to insert module and returns a suitable message
        public string validateModuleInfo(Module m)
        {
            string msg = validation(m.ModuleName,m.Description);
            if (msg[0].Equals("E"))//alles begin met e
            {
                return msg;
            }
            else
            {
                if (handle.addModule(m.ModuleCode,m.ModuleName,m.Description,m.onlineResources))
                    return "New Module has been added.";
                else
                    return "Module could not be added.";
            }
        }

        //[R] Reads and returns all modules in the DB
        public List<Module> getModuless()
        {
            DataHandler handle = new DataHandler();
            return handle.readModules();
           
        }

        //[U] Runs validation, if everything is correct, attempts to update module info and returns a suitable message
        public string moduleInfoChanged(Module m)
        {
            string msg = validation(m.ModuleName, m.Description);
            if (msg[0].Equals("E"))//alles begin met e
            {
                return msg;
            }
            else
            {
                if (handle.updateModule(m.ModuleCode,m.ModuleName,m.Description,m.onlineResources))
                    return "Module with Code: "+m.ModuleCode+", has been updated.";
                else
                    return "Module could not be updated.";
            }
        }
    
         //[D] Deletes a module in the DB based on its ID
        public string moduleDeleted(string mCode)
        {

            DataHandler handle = new DataHandler();
            if (handle.deleteModule(mCode))
            {
                return "Module Deleted";
            }
            else
            {
                return "fail to delete";
            }

        }

        //[S] Finds a Module_Code in a list of all the modules
        public List<Module> searchModule(int mCode)
        {
            List<Module> allList = handle.readModules();
            List<Module> newList = new List<Module>();
            foreach (Module m in allList)
            {
                if (m.ModuleCode.Equals(mCode))
                {
                    newList.Add(new Module(m.ModuleCode, m.ModuleName,m.Description,m.onlineResources));
                }
            }
            return newList;
        }

        public int CompareTo(Module other)
        {
            return this.ModuleCode.CompareTo(other.ModuleCode);
        }

       
    }
}