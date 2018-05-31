using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mine_Sweeping;
using Mine_Sweeping_Window;
using System.Collections.Generic;

namespace Mine_Sweeping.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Get_Valid_Mines_Coordinate()
        {
            //Arrange
            GridObject gridObject = new GridObject();
            gridObject.SetCoordinate(1, 1);

            Dictionary<GridObject, GridObject> mockObjectTable = new Dictionary<GridObject, GridObject>();
            mockObjectTable.Add(gridObject.Clone(), gridObject.Clone());

            ObjectList objectList = new ObjectList();
            objectList.Add(1, 1);

            //Act
            var result = objectList.ObjectTable;
            GridObject value1 = null;
            GridObject value2 = null;
            foreach (var item in result)
            {
                value1 = item.Value;
            }
            foreach (var item in mockObjectTable)
            {
                value2 = item.Value;
            }

            //Assert
            Assert.AreEqual(value2.XCoordinate, value1.XCoordinate);
            Assert.AreEqual(value2.YCoordinate, value1.YCoordinate);
        }

        [TestMethod]
        public void Can_Get_Valid_Mines_Count()
        {
            //Arrange
            GridObject gridObject = new GridObject();
            gridObject.SetCoordinate(1, 1);

            GridObject gridObject2 = new GridObject();
            gridObject2.SetCoordinate(1, 2);

            Dictionary<GridObject, GridObject> mockObjectTable = new Dictionary<GridObject, GridObject>();
            mockObjectTable.Add(gridObject.Clone(), gridObject.Clone());
            mockObjectTable.Add(gridObject2.Clone(), gridObject2.Clone());

            ObjectList objectList = new ObjectList();
            objectList.Add(1, 1);
            objectList.Add(1, 2);

            //Act
            var result = objectList.ObjectTable;


            //Assert
            Assert.AreEqual(result.Count, mockObjectTable.Count);
        }

    }
}
