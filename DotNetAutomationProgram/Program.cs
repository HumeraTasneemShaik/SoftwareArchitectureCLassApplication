﻿// See https://aka.ms/new-console-template for more information
using DotNetAutomationBinding;

Console.WriteLine("Hello, World! HI ");


Session theSession = Session.GetSession;

Part thePart = theSession.MakePart("SomePart.prt");

thePart.Save();
