---
layout: post
title:  "Static Keyword In C#"
date:   2017-06-08 07:04:22 +0545
categories: programming
description: "When a method is static then it can be invoked directly from the class level without creating an object. This is the reason for making a main() method static."
---

When a method is static then it can be invoked directly from the class level without creating an object. This is the reason for making a main() method static.

Points for static keyword
** A static method can be invoked directly from the class level
** A static method not requires any class object
** Any main() method is shared through entire class scope so it always appears with static keyword.

Points for static class
** Contains only static memebers.
** Cannot be instantiated.
** Is sealed.
** Cannot contain Instance Constructors.