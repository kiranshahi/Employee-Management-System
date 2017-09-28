---
layout: post
title:  "Do A Program Have Multiple Main Method"
date:   2017-06-08 07:04:22 +0545
categories: programming
description: "Basically main method is the entry point into application. We can define multiple Main methods but we have to select a single main method when running our app. Need to specify which to use as the entry point for the application by our compiler."
---

Basically main method is the entry point into application. We can define multiple Main methods but we have to select a single main method when running our app. Need to specify which to use as the entry point for the application by our compiler.

For example:

using System;
using System.Collections.Generic;
using System.Text;

	namespace Multiple_MainClasses
	{
		class A
		{
			static void Main(string[] args)
			{
				Console.WriteLine("I am from Class A");
				Console.ReadLine();
			}
		}

		class  B 
		{
			static void Main(string[] args)
			{
				Console.WriteLine("I am from Class B");
				Console.ReadLine();
			}
		}
	}

	When we run this code we will get compilation error. To resolve the error we need to specify which Main method we want to execute. To specify the entry point we can follow the following stapes:

	1) Go to project properties in solution explorer or press ctrl + alt + L.
	2) Go to application tab
	3) Select class with method which we want to execute