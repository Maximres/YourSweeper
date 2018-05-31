using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public interface IGetSetValue
    {
        /// <summary>
        /// �������������� ���� � ������
        /// </summary>
        void Initialization();

        /// <summary>
        /// ���������� ���������� �����
        /// </summary>
        int Lines { get;set;}

        /// <summary>
        /// ���������� ���������� �������
        /// </summary>
        int Columns { get;set;}

        int MineNums { get;set;}
    }
}
