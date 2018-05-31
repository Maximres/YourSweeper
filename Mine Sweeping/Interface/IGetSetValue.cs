using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public interface IGetSetValue
    {
        /// <summary>
        /// Инициализирует поле с минами
        /// </summary>
        void Initialization();

        /// <summary>
        /// Определяет количество линий
        /// </summary>
        int Lines { get;set;}

        /// <summary>
        /// Определяет количество колонок
        /// </summary>
        int Columns { get;set;}

        int MineNums { get;set;}
    }
}
