using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public class ObjectList
    {
        private readonly Dictionary<GridObject, GridObject> objectTable = new Dictionary<GridObject, GridObject>();

        /// <summary>
        /// �������� �������� �  (x,y).
        /// </summary>
        /// <param name="index">����������.</param>
        /// <returns>��������.</returns>
        public GridObject this[int x, int y]
        {
            get
            {
                using (GridObject tmp = new GridObject())
                {
                    tmp.SetCoordinate(x, y);

                    foreach (GridObject cur in this.objectTable.Keys)
                    {
                        if (tmp.Equals(cur as object))
                            return objectTable[cur];
                    }
                    return null;
                }
            }
        }
        /// <summary>
        /// ��������� �������
        /// </summary>
        public int Length
        {
            get
            {
                return this.objectTable.Count;
            }
        }

        /// <summary>
        /// �������� Dictionary ����� ���������� �� KeyedList.
        /// </summary>
        public Dictionary<GridObject, GridObject> ObjectTable
        {
            get { return objectTable; }
        }

        /// <summary>
        /// ������ �������.
        /// </summary>
        public void Clear()
        {
            objectTable.Clear();
        }

        public bool ContainsKey(int x, int y)
        {
            using (GridObject tmp = new GridObject())
            {
                tmp.SetCoordinate(x, y);
                foreach (GridObject cur in this.objectTable.Keys)
                {
                    if (tmp.Equals(cur as object))
                        return true;
                }
                return false;
            }
        }

        /// <summary>
        /// ��������� ��������-����
        /// </summary>
        /// <param name="key">����.</param>
        /// <param name="value">����������.</param>
        public void Add(int x, int y)
        {
            try
            {
                GridObject tmp = new GridObject();
                tmp.SetCoordinate(x, y);
                objectTable.Add(tmp.Clone(), tmp.Clone());
            }
            catch
            {
            }
        }


        /// <summary>
        /// ������� ��������.
        /// </summary>
        /// <param name="key">����, ���������������� ��������.</param>
        /// <returns>True ���� �������.</returns>        
        public bool Remove(int x, int y)
        {
            GridObject tmp = new GridObject();
            tmp.SetCoordinate(x, y);
            foreach (GridObject cur in this.objectTable.Keys)
            {
                if (tmp.Equals(cur as object))
                    return objectTable.Remove(cur);
            }
            return false;
        }
    }
}
