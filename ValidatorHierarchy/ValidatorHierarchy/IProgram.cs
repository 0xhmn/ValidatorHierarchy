using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorHierarchy
{
    public interface IProgram
    {
        bool AllowIncompleteSubmissions { get; set; }
        string AreaName { get; set; }
        string ShortName { get; set; }
        string Name { get; set; }
        int Id { get; set; }
    }
}
