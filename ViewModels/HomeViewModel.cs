using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; } = "Header";
        public string Message { get; set; } = "Some content!";
        public string FooterTitle { get; set; } = "Footer";
    }
}
