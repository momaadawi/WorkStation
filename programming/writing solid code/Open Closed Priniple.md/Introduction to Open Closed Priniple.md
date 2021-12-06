# Introduction to Open Closed Priniple
Software entities should be open for extension, but closed for modification.

#### Open for extension
This means that the behavior of the module can be extended .
As the requirements of the application change, we are able to extend the module
with new behaviors that satisfy those changes . In other words, we are able to
change what the module does

#### Closed for modification.
Extending the behavior of a module does not result
in changes to the source or binary code of the module . The binary executable
version of the module, whether in a linkable library, a DLL, or a Java .jar, remains
untouched 


There are exceptions to the restrictive “closed for modification” clause of the OCP that are sometimes cited: changes for fixing bugs or defects and changes that can be made without any client awarenes

* Bug fixes
* Client awareness

# Extention Point
Classes that honor the OCP should be open to extension by containing defined extension points where future functionality can hook into the existing code and provide new behavior

When there are no extension points, clients are forced to change
#### create extention point
* Virtual methods
* Abstract Methods (Template Method pattern)
    - is a behavioral design pattern that allows you to defines a skeleton of an algorithm in a base class and let subclasses override the steps without changing the overall algorithm’s structure.
* Interface inhertince
 
# Protect Varitaion
Identify points of predicted variation and create a stable interface around them

### Predicted variation

### A stable interface