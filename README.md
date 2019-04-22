# Some Algorithms
Some structures in C# .Net Core to test and play with code

# Example 1

Write some code, that will flatten an array of arbitrarily nested arrays of integers into a flat array of integers. 

e.g. [[1,2,[3]],4] -> [1,2,3,4].


# Extension methods without using linq 

class FlatArrayExtension  


* e.g. [[1,2,[3]],4] -> [1,2,3,4]. 
            
  ```Console.WriteLine("Input 1: [[1,2,[3]],4]"); 
  object[] array1 = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 } };  
  var flatArray1 = array1.GetFlatArray();  
  WriteArray(flatArray1, "Flat 1");```
  
output:
Input 1: [[1,2,[3]],4]
Flat 1 array: [  1 , 2 , 3 , 4  ]

# XUnit Test

``` public class FlatArrayUnitTest
    {
        /// <summary>
        /// input: [[1,2,[3]],4]
        /// expected: [1,2,3,4],
        /// </summary>
        [Fact]
        public void IntArrayTest()
        {
            object[] array = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 } };
            Assert.Equal(new object[] { 1, 2, 3, 4 }, array.GetFlatArray());
        }

        /// <summary>
        /// input:  [[1,2,[3]],4, [hi,bye,[5]] ]
        /// expected: [1,2,3,4,hi,bye,5]
        /// </summary>
        [Fact]
        public void IntStringArrayTest()
        {
            object[] array = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 },
                              new object[] {"hi","bye",new object[] { 5 } } };
            Assert.Equal(new object[] { 1, 2, 3, 4, "hi", "bye", 5 }, array.GetFlatArray());
        }

        
    } 

```

# Run tests
In the Path:

SomeAlgorithms\XUnitTestSomeAlgorithms> dotnet test

Starting test execution, please wait...

Total tests: 2. Passed: 2. Failed: 0. Skipped: 0.

Test Run Successful.

Test execution time: 1.3827 Seconds


