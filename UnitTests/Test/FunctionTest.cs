namespace UnitTests.Test
{
    public static class FunctionTest
    {
        //Classname_MethodName_ExpectedResult
        public static void Function_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - go get your variables, whatever you need, classes, functions
                int num = 0;
                Function function = new Function();

                //Act - execute this function
                string result = function.ReturnsPikachuIfZero(num);

                //Assert - whatever is  returned is it what you want?
                if (result == "pikachu")
                    Console.WriteLine("PASSED: Function_ReturnsPikachuIfZero_ReturnString");
                else
                    Console.WriteLine("FAILED: Function_ReturnsPikachuIfZero_ReturnString");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
