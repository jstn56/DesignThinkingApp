

namespace DesignThinkingXTest
{
    
    public class Tests
    {
        [Fact]
        public void FixBug_Convert_01()
        {
            // Rule: The assertation must not be changed

            var value = "24 1";

            var intValue = int.Parse(value);

            Assert.Equal(241, intValue);

            // Your explanation: 
            // 
            // 
        }
    }
}