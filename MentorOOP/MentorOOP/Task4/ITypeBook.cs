using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOOP.Task4
{
    internal interface ITypeBook
    {
        List<string[]> Books { get; }
        List<string[]> BookType { get; }
    }
}
