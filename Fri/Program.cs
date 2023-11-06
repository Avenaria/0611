// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");
static void Main()
{
    AppDomain Dom = AppDomain.CreateDomain("Domain");
    Assembly asm = Dom.Load(AssemblyName.GetAssemblyName("Biblio.pdb"));
    Module module = asm.GetModule("Biblio.pdb");
    Type type = module.GetType("");
    MethodInfo method = type.GetMethod("DoSome");
    method.Invoke(null, null);
}