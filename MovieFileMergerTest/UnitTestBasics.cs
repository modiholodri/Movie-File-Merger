using Movie_File_Merger;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Movie_File_Merger {
    [TestClass( )]
    public class UnitTestBasics {
        [TestMethod( )]
        public void StandardizeDateTest( )
        {
            DateTime dtNew = new DateTime( 2017, 01, 13 );

            string str20170113 = MFMForm.StandardizeDate( dtNew );

            Assert.Fail( );
        }
    }
}

namespace MovieFileMergerTest {
    [TestClass]
    public class UnitTestBasics {
        [TestMethod]
        public void TestStandardizeDate( )
        {

        }
    }
}
