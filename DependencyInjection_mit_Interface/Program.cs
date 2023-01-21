using DependencyInjection_mit_Interface;

Hund h = new Hund();
var pfleger = new Tierpfleger();
h.Name = pfleger.setName();
pfleger.setHund(h);
Console.WriteLine(pfleger.h.ToString());
