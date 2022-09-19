using System;
using Xunit;

namespace DelegatesTest
{
    public class UnitTest1
    {
        [Fact]
        public void RunReturns_OnWord_forWords()
        {
            Delegates.InputReader retriever = new Delegates.InputReader();
            var result = retriever.Checkinput();
            Assert.Equal("OnWord",result);
        }
    }
}
