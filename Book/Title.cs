using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Title
    {
        public string Content { get; set; }

        public void Show() => Console.WriteLine(Content);
    }
}
