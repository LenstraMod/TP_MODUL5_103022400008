
﻿
using TP_MODUL5_103022400008;

HaloGeneric hello = new HaloGeneric();

Console.Write("Isi nama panggilan anda: ");
String name = Console.ReadLine();

hello.SapaUser<string>(name);

DataGeneric<string> data = new DataGeneric<string>("103022400008");

data.PrintData(); 

