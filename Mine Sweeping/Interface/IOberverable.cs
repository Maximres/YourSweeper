using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Реализация шаблона проектирования "Наблюдатель"
/// </summary>
namespace Mine_Sweeping
{
    public interface IOberverable
    {
        void Register(IObserver ober);

        void UnRegister(IObserver ober);
    }
}
