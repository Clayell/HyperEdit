using System;

namespace HyperEdit
{
    public static class PrincipiaWrapper
    {
        public static bool Init()
        {
            Extensions.Log("Attempting to find Principia....");

            foreach (AssemblyLoader.LoadedAssembly assembly in AssemblyLoader.loadedAssemblies)
            {
                try
                {
                    if (assembly.assembly.GetName().Name == "principia.ksp_plugin_adapter")
                    {
                        Extensions.Log($"Principia found.");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Extensions.Log($"Error loading Principia: {ex}");
                }
            }

            Extensions.Log($"Principia not found.");

            return false;
        }
    }
}
