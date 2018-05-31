using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// ���������� ������� �������������� "�����������"
/// </summary>
namespace Mine_Sweeping
{
    public interface IOberverable
    {
        void Register(IObserver ober);

        void UnRegister(IObserver ober);
    }
}
