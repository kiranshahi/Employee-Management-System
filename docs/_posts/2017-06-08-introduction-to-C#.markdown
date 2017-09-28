---
layout: post
title:  "What is C# and .NET"
date:   2017-06-08 07:04:22 +0545
categories: C#, .NET
description: "C# is an elegant and type-safe object-oriented programming language that enables developer to build a variety of secure and robust applications on the top of .NET Framework."
---

C# is an elegant and type-safe object-oriented programming language that enables developer to build a variety of secure and robust applications on the top of .NET Framework. It was developed by the team which was led by Anders Hejlsberg. C# was first appeared on 2000 AD.

<h3>Hello World program in C#</h3>
{% highlight C# %}
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
{% endhighlight %}


<h2>Differences between C# and .NET</h2>

C# is a general purpose object-oriented programming language like Java, C++ etc which runs on the .NET Framework.
Where as .NET is a blanket term that tends to cover both the .NET Framework(an application framework library) and the Common Language Runtime which is the runtime in which .NET assemblies run.

<b>Remember:</b> `.NET isn't just a library, but also a runtime for executing applications.`

i.e. .NET Framework includes a large class library named Framework Class Library (FCL) and provides user interface, data access, database connectivity, cryptography, web application development, numeric algorithms and network communications.

<h4>References</h4>

[What is the difference between C# and .NET?][links]

[links]: https://stackoverflow.com/questions/2724864/what-is-the-difference-between-c-sharp-and-net