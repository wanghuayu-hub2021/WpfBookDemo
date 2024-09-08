using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    public  interface IView
    {
        bool isChanged { get; set;}

        void SetBinding();
        void Clear();
        void Save();
        void Refresh();
    }
}
