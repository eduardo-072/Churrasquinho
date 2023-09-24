
int AdultosComAlcool, AdultosSemAlcool, crianças, adultos, pessoas;
double carne, cerveja, refrigerante, água, acompanhamentos;

Console.Write("====== Churasquinho para família =========\n");

Console.Write("Adultos que consomem cerveja.........:");
AdultosComAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos que não consomem cerveja.....:");
AdultosSemAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças.............................:");
crianças = Convert.ToInt32(Console.ReadLine());


adultos = AdultosComAlcool + AdultosSemAlcool;
pessoas = adultos + crianças;


carne = 0.4 * adultos + 0.2 * crianças;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * AdultosComAlcool;
refrigerante = 0.5 * AdultosSemAlcool + crianças;
água = 0.4 * pessoas;


Console.WriteLine($"Carne...........................: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos.................: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja..........................: {cerveja:N1}l");
Console.WriteLine($"Refrigerante.....................: {refrigerante:N1}l");
Console.WriteLine($"Água..............................: {água:N1}l");




// ﻿int adultosComAlcool, adultosSemAlcool, criancas, adultos, pessoas;
// double carne, acompanhamentos, cerveja, refrigerante, agua;

// Console.WriteLine("--- Churrasco ---\n");

// Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
// adultosComAlcool = Convert.ToInt32(Console.ReadLine());

// Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
// adultosSemAlcool = Convert.ToInt32(Console.ReadLine());

// Console.Write("Crianças........................................: ");
// criancas = Convert.ToInt32(Console.ReadLine());

// adultos = adultosComAlcool + adultosSemAlcool;
// pessoas = adultos + criancas;

// carne = 0.4 * adultos + 0.2 * criancas;
// acompanhamentos = 0.2 * pessoas;
// cerveja = 2 * adultosComAlcool;
// refrigerante = 0.5 * (adultosSemAlcool + criancas);
// agua = 0.4 * pessoas;

// Console.WriteLine();

// Console.WriteLine($"Carne.............: {carne:N1}kg");
// Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1}kg");
// Console.WriteLine($"Cerveja...........: {cerveja:N1}l");
// Console.WriteLine($"Refrigerante......: {refrigerante:N1}l");
// Console.WriteLine($"Água..............: {agua:N1}l");