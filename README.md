# Some Algorithms
Some structures in C# .Net Core to test and play with code

# Example 1

Write some code, that will flatten an array of arbitrarily nested arrays of integers into a flat array of integers. 

e.g. [[1,2,[3]],4] -> [1,2,3,4].


# Extension methods without using linq 

class FlatArrayExtension  


* e.g. [[1,2,[3]],4] -> [1,2,3,4]. *
            
  ```Console.WriteLine("Input 1: [[1,2,[3]],4]");  
  
  object[] array1 = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 } };
  
  var flatArray1 = array1.GetFlatArray();
  
  WriteArray(flatArray1, "Flat 1");
  
  output:
  
  Input 1: [[1,2,[3]],4]
  
  Flat 1 array: [  1 , 2 , 3 , 4  ]```

# XUnit Test
In the Path:

SomeAlgorithms\XUnitTestSomeAlgorithms> dotnet test
