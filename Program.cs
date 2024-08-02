double sBruto = 0, sLiquido = 0, sHora = 0, hrsTrabalhadas = 0, desconto = 0, hExtra = 0, inss = 0, irpf = 0;
string nome ;
Console.WriteLine("Digite o nome do colaborador: ");
nome = Console.ReadLine();
Console.WriteLine("Olá " + nome + " digite agora o seu salário bruto: ");
sBruto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
hrsTrabalhadas = Convert.ToInt32(Console.ReadLine());

sHora = sBruto / 160;
Console.WriteLine(nome + ", de acordo com suas informações, seu salário hora é de: " + sHora + "R$\n");

//calculando INSS

if (sBruto <= 1412)
{
    inss = sBruto * 0.075;
    Console.Write("Você paga " + inss + "R$ de INSS\n\n");
}
else if (sBruto > 1412 & sBruto <= 2666.68)
{
    inss = sBruto * 0.09;
    Console.Write("Você paga " + inss + "R$ de INSS\n\n");
}
else if (sBruto > 2666.68 & sBruto <= 4000.03)
{
    inss = sBruto * 0.12;
    Console.Write("Você paga " + inss + "R$ de INSS\n\n");
}
else if (sBruto > 4000.03 & sBruto <= 7786.02)
{
    inss = sBruto * 0.14;
    Console.Write("Você paga " + inss + "R$ de INSS\n\n");
}

//calculando IRPF

if (sBruto <= 2112)
{
    Console.Write("Imposto de renda isento");
}
else if (sBruto > 2112 & sBruto <= 2826.66)
{
    irpf = sBruto * 0.075;
    Console.Write("Você paga " + irpf + "R$ de Imposto de renda\n\n");
}
else if (sBruto > 2826.66 & sBruto <= 3751.06)
{
    irpf = sBruto * 0.15;
    Console.Write("Você paga " + irpf + "R$ de Imposto de renda\n\n");
}
else if (sBruto > 3751.06 & sBruto <= 4664.68)
{
    irpf = sBruto * 0.225;
    Console.Write("Você paga " + irpf + "R$ de Imposto de renda\n\n");
}
else if (sBruto > 4664.68)
{
    irpf = sBruto * 0.275;
    Console.Write("Você paga " + irpf + "R$ de Imposto de renda\n\n");
}

// calculando descontos e hora extra

if (hrsTrabalhadas > 160)
{
    hExtra = hrsTrabalhadas - 160;
    hExtra = hExtra * sHora;
    Console.Write("Você recebeu " + hExtra + "R$ por Horas Extras\n\n");
}
else if (hrsTrabalhadas < 160)
{
    desconto = 160 - hrsTrabalhadas;
    desconto = desconto * sHora;
    Console.Write("Você recebeu um desconto de " + desconto + "R$\n\n");
}

sLiquido = sBruto - desconto - inss - irpf + hExtra;
Console.Write("Seu salário líquido é " + sLiquido + " devido aos descontos e tributos! ");