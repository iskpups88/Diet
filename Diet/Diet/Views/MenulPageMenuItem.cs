using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Views
{

    public class MenulPageMenuItem
    {
        public MenulPageMenuItem()
        {
            TargetType = typeof(MenulPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}