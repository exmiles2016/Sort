using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    
    public class Context
    {
        private Sort_method _sort_method; //позволяет автоматически переключаться между конкретными реализациями

        public Context(Sort_method sort_method) //конструктор, инициализирующий объект стратегий
        {
            _sort_method = sort_method;
        }

        public void SetStrategy(Sort_method sort_method) // метод для установки стратегии, служит для её смены
        {
            _sort_method = sort_method;
        }

        
    }
}
