using IDEF.LogUtils;
using IDEF.WorkFlow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.ViewModels
{
    public class AssemblyHelper
    {
        public static IEnumerable<Model.NodeTypeModel> GetRawActivityTypes(string filePath)
        {

            Assembly.LoadFile(filePath);

            IEnumerable<Model.NodeTypeModel> rawTypes = AppDomain.CurrentDomain.GetAssemblies()
                .Where(x => x.FullName.StartsWith("IDEF.WorkDemo"))
                //.Where(x => x.FullName.StartsWith(typeof(IWork.IWork).Namespace))
                .SelectMany(x => GetTypes(x))
                .Where(x => !x.IsAbstract)
                .Where(x => !x.IsInterface)
                .Where(x => !x.IsGenericType)
                .Where(x => typeof(IWork.IWork).IsAssignableFrom(x))
                .Select(x => new Model.NodeTypeModel(x));
            return rawTypes;
        }


        public static Type[] GetTypes(Assembly x)
        {

            Type[] types = new Type[] { };
            try
            {
                types = x.GetTypes();
                //Log.Debug($"GetRawActivityTypes types: {types}");
            }
            catch (ReflectionTypeLoadException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Exception exSub in ex.LoaderExceptions)
                {
                    sb.AppendLine(exSub.Message);
                    FileNotFoundException exFileNotFound = exSub as FileNotFoundException;
                    if (exFileNotFound != null)
                    {
                        if (!string.IsNullOrEmpty(exFileNotFound.FusionLog))
                        {
                            sb.AppendLine("Fusion Log:");
                            sb.AppendLine(exFileNotFound.FusionLog);
                        }
                    }
                    sb.AppendLine();
                }
                string errorMessage = sb.ToString();
                Log.Error($"GetRawActivityTypes FullName: {x.FullName} ReflectionTypeLoadException {ex}, Err:{errorMessage}");
                throw ex;
            }
            catch (Exception ex)
            {
                Log.Error($"GetRawActivityTypes FullName: {x.FullName} Exception {ex}");
                throw ex;
            }

            return types;
        }

    }
}
