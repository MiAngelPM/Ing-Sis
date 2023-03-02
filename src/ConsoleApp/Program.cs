double radio = 5;
double altura = 10;
double pi = 3.1416;
double perimetro = Application.Circulo.Perimetro(pi,radio);
double area = Application.Circulo.Area(pi,radio);
double volumen = Application.Cilindro.Volumen(area,altura);

Console.WriteLine($"El perímetro de la base de un Cilindro con un radio de {radio}cm es de {perimetro}cm");
Console.WriteLine($"El área de la base de un Cilindro con un radio de {radio}cm es de {area}cm2");
Console.WriteLine($"El volumen un Cilindro con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");