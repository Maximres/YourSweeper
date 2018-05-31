using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Реализация шаблона проектирования "Наблюдатель"
/// </summary>
namespace Mine_Sweeping
{
    public interface IObserver
    {
        void Update(EventArgs brgs);
    }
}
