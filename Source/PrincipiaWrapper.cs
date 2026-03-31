using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Diagnostics;

namespace HyperEdit
{
    public static class PrincipiaWrapper
    {
        public static bool Init()
        {
            Log("Attempting to find Principia....");

            foreach (AssemblyLoader.LoadedAssembly assembly in AssemblyLoader.loadedAssemblies)
            {
                try
                {
                    if (assembly.assembly.GetName().Name == "principia.ksp_plugin_adapter")
                    {
                        Log($"Principia found.");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Log($"Error loading Principia: {ex}");
                }
            }

            Log($"Principia not found.");

            return false;
        }

        private static void Log(string message) => Extensions.Log(message);
    }
}
