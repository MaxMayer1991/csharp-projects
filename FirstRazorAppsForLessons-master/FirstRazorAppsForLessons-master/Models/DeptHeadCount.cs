using System;
using System.Collections.Generic;
using System.Text;

namespace FirstRazorApp.Models
{
    public class DeptHeadCount
    {
        // Первое свойство департамента
        public Dept Stan { get; set; }
        // Второе свойство - счётчик
        public int Count { get; set; }
    }
}
