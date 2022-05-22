using System;
using System.Collections.Generic;
using System.Linq;
using DialNumber;
using Xunit;

namespace DialNumberTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestNormal()
        {
            //
            //arrange
            //
            GetAnimal getAnimal = new GetAnimal();
            List<object> list = new List<object>();
            List<object> returnList = new List<object>();
            //
            //act
            //
            list.Add("CAT");
            list.Add("DOG");
            list.Add("BAT");
            returnList = getAnimal.GetAnimals("228", list);

            //
            //assert
            //
            var expected = new List<string>();
            expected.AddRange(new[] {"CAT","BAT"});
            var actual =  new List<object>();
            actual.AddRange(returnList);
            Assert.True(expected.SequenceEqual(actual));
        }
        [Fact]
        public void TestSqlLoader()
        {
            //
            //arrange
            //
            GetAnimal getAnimal = new GetAnimal();
            SqlLoader sqlLoader = new SqlLoader();
            List<object> list = new List<object>();
            List<object> returnList = new List<object>();
            //
            //act
            //

            // list should be  what sql query has
            list = sqlLoader.SqlLoading();
            returnList = getAnimal.GetAnimals("228", list);
            // returnList should give us the result we need

            //
            //assert
            //
            var expected = new List<string>();
            expected.AddRange(new[] { "CAT", "BAT" });
            var actual = new List<object>();
            actual.AddRange(returnList);
            Assert.True(expected.SequenceEqual(actual));
        }
        [Fact]
        public void TestTxtLoader()
        {
            //
            //arrange
            //
            GetAnimal getAnimal = new GetAnimal();
            TxtLoader txtLoader = new TxtLoader();
            List<object> list = new List<object>();
            List<object> returnList = new List<object>();
            //
            //act
            //

            // list should be  what sql query has
            list = txtLoader.txtLoading();
            returnList = getAnimal.GetAnimals("228", list);
            // returnList should give us the result we need

            //
            //assert
            //
            var expected = new List<string>();
            expected.AddRange(new[] { "CAT", "BAT" });
            var actual = new List<object>();
            actual.AddRange(returnList);
            Assert.True(expected.SequenceEqual(actual));
        }

    }
}
