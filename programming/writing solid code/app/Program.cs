using System;
using System.Collections.Generic;

namespace app
{
    public  class BaseClass
    {
      public  virtual void print(){
            System.Console.WriteLine("BaseClass");
        }
    }
    public class SubClass : BaseClass
    {
        public  void print(){
            System.Console.WriteLine("Drived Class");
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.print();

            BaseClass subClass = new SubClass();
           subClass.print();
        }
    }
}
