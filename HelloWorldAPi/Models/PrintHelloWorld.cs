using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAPi.Models
{
    public class PrintHelloWorld
    {
        public string PrintHello()
        {
            /*Write a ‘Hello World’ program.
             * a The program has 1 current business requirement – write “Hello World” to the console/screen.
             * b The program should have an API that is separated from the program logic to eventually
             * support mobile applications, web applications, or console applications, or windows services.
             * c The program should support future enhancements for writing to a database, console application, etc.
             * i Use common design patterns (inheritance, e.g.) to account for these future concerns.
             * ii Use configuration files or another industry-standard mechanism for determining 
             * where to write the information to.*/
            return "Hello World!";
        }
    }
}