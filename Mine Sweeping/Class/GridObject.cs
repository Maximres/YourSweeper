using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mine_Sweeping
{
    [Serializable]
    public class GridObject : ICoordinate, IDisposable
    {
        #region Private Field
        /// <summary>
        /// x координата
        /// </summary>
        private int xCoordinate;
        /// <summary>
        /// y координата
        /// </summary>
        private int yCoordinate;
        /// <summary>
        /// 
        /// </summary>
        private bool hadAccessed = false;

        #endregion

        #region Constructor & Deconstructor
        public GridObject()
        {
            this.xCoordinate = this.yCoordinate = 0;
        }

        public GridObject(int x, int y)
        {
            this.xCoordinate = x;

            this.yCoordinate = y;

            hadAccessed = false;
        }
        #endregion

        #region Public Attribute
        /// <summary>
        /// получает x координату
        /// </summary>
        public int XCoordinate
        {
            get
            {
                return this.xCoordinate;
            }
        }
        /// <summary>
        /// получить y координаты
        /// </summary>
        public int YCoordinate
        {
            get
            {
                return this.yCoordinate;
            }
        }
        /// <summary>
        ///  Проверка доступа
        /// </summary>
        public bool HasAccessed
        {
            get
            {
                return this.hadAccessed;
            }
            set
            {
                this.hadAccessed = value;
            }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// установка х и у
        /// </summary>
        /// <param name="x"> x </param>
        /// <param name="y"> y </param>
        public void SetCoordinate(int x, int y)
        {
            this.xCoordinate = x;
            this.yCoordinate = y;
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (null == obj)
            {
                return false;
            }
            Type thisType = GetType();
            Type thatType = obj.GetType();

            if (thatType != thisType)
            {
                return false;
            }

            Object thisObj = this;
            Object thisResult, thatResult;


            FieldInfo[] thisFields = thisType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (FieldInfo fld in thisFields)
            {
                thisResult = fld.GetValue(thisObj);

                thatResult = fld.GetValue(obj);

                if (thisResult == null)
                {
                    if (thatResult != null)
                    {
                        return false;
                    }
                }
                else
                    if (!thisResult.Equals(thatResult))
                {
                    return false;
                }
            }

            return true;

        }

        public override int GetHashCode() => base.GetHashCode();

        public override string ToString() => string.Format("object's coordinate is ({0},{1})", xCoordinate, yCoordinate);

        public GridObject Clone()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memory = new MemoryStream();
            formatter.Serialize(memory, this);
            memory.Position = 0;
            return (formatter.Deserialize(memory) as GridObject);
        }

        public void Dispose()
        {
        }
    }
}
