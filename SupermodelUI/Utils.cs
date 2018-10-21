using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SupermodelUI
{
    public class Utils
    {
        public static List<FieldInfo> GetConstants(Type type)
        {
            FieldInfo[] fieldInfo = type.GetFields(BindingFlags.Public | BindingFlags.Static);
            return fieldInfo.Where(fi => fi.IsLiteral).ToList();
        }
    }
}
